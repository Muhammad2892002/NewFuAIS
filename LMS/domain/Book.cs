using LMS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Enum.borrowcheck;

namespace LMS.Domains
{
    public class Book : LibraryItem,IBorrowable
    {
        static string indicatedtxt;
        static Book bookk;
       
        public Book(Book []book)
        {

            foreach (var item in book)
            {
                newListBook.Add(item);
                
            }









        }
        public Book()
        {
            
        }
        #region props 
        public int NumberofPages { get; set; }
        public string ?Genre { get; set; }

        public bool? Borrow(string bookName,string memberName)
        {
            bool? flag=null;
            bool? result=CheckAvailability(bookName);
            if (result != null)
            {


                if (result == true)
                {
                    bookk.Isborrowed = Isborrowed.yes;
                    indicatedtxt = "Borrowed";
                      flag = true;
                    GetDetails(memberName);
                  

                }
                else if (result == false)
                {
                    Console.WriteLine("sorry to tell you but its borrowed");
                   
                    flag= false;

                }
            }
            return flag;

            
        }

        #endregion
        #region methods 
        public bool? CheckAvailability(string name)
        {
             bookk = Search(name);
            if (bookk != null)
            {
                if (bookk.Isborrowed == Isborrowed.no)
                {
                    return true;

                }
                else if (bookk.Isborrowed == Isborrowed.yes)
                {
                    Console.WriteLine("The book is borowed");
                    return false;
                }
            }
            Console.WriteLine("Enter Valid Data");
            return null;



        }
        public override void GetDetails(string name)
        {
            //Console.WriteLine($" Book Name:{bookk.Title}");
            //Console.WriteLine($" Author Name:{bookk.Author}");
            //Console.WriteLine($"Genre:{bookk.Genre}");
            //Console.WriteLine($"Is Borrowed?:{bookk.Isborrowed}");
            //Console.WriteLine($"ISBN:{bookk.GetISBN()}");
            Console.WriteLine($"{name},{bookk.Title} By:{bookk.Author}.");
            Console.WriteLine($"{indicatedtxt} Book{bookk.Title}");


        }

        public bool? Return(string bookName,string memberName)
        {
            bool? flag=null;
            bookk = Search(bookName);
            if (bookk != null)
            {
                if (bookk.Isborrowed == Isborrowed.yes)
                {
                    bookk.Isborrowed = Isborrowed.no;
                    indicatedtxt = "Returned";
                    flag = true;
                   
                    GetDetails(memberName);
                    Console.WriteLine("\n\nThe Book successfully Returned");
                    bookk.Isborrowed = Isborrowed.no;
                    

                }
                else if (bookk.Isborrowed == Isborrowed.no) {
                    Console.WriteLine("ITS NOT BORROWED!!!!!");
                    flag = false;

                }

            }
            return flag;
        }
        public static Book? Search(string name) {
            Book book = newListBook.FirstOrDefault(q => q.Title == name);
            if (book != null)
            {

                if (book.Isborrowed == Isborrowed.yes)
                {

                    return book;
                }
                else
                {
                    return book;

                }
            }
            else {
                
                return null;
            
            }

        }

        #endregion
    }
}
