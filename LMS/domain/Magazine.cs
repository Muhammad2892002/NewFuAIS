using LMS.Enum;
using LMS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.Enum.borrowcheck;
using System.Xml.Linq;

namespace LMS.Domains
{
    public class Magazine : LibraryItem, IBorrowable
    {
        public static string Indicatedtxt;
        #region proprties
        public int IssueNumber { get; set; }

      



        #endregion
        static Magazine localMagazine;
        public Magazine(Magazine[] magazines )
        {
            foreach (var item in magazines)
            {
                newListMagazine.Add(item);

            }

        }
        public Magazine()
        {
            
        }

        #region Methods
        public bool? CheckAvailability(string name) {
             localMagazine = Search(name);
            if (localMagazine != null)
            {
                if (localMagazine.Isborrowed == Isborrowed.no)
                {
                    return true;

                }
                else if (localMagazine.Isborrowed == Isborrowed.yes)
                {
                    Console.WriteLine("The magaziene is borowed");
                    return false;
                }
            }
            Console.WriteLine("Enter Valid Data");
            return null;

        }
        public override void GetDetails(string name)
        {
            //Console.WriteLine($"IssueNumber:{localMagazine.IssueNumber}");
            //Console.WriteLine($"Author:{localMagazine.Author}");
            //Console.WriteLine($"publishDate{localMagazine.PublishDate}");
            Console.WriteLine($"{name},{localMagazine.Title} By:{localMagazine.Author}");
            Console.WriteLine($"{ Indicatedtxt} Magazine  {localMagazine.Title}");


        }

        public bool? Return(string magazineName,string name)
        {
            bool? flag = null;
            localMagazine = Search(magazineName);
            if (localMagazine != null)
            {
                if (localMagazine.Isborrowed == Isborrowed.yes)
                {
                    Indicatedtxt = "Returned";
                    flag = true;

                    GetDetails(name);
              
                    localMagazine.Isborrowed = Isborrowed.no;
                   

                }
                else if (localMagazine.Isborrowed == Isborrowed.no)
                {
                    flag = false;
                    Console.WriteLine("ITS NOT BORROWED!!!!!");
                    

                }

            }
            return flag;
        }
        public bool? Borrow(string name,string memeberName) {
            bool ? flag = null;
            bool? result = CheckAvailability(name);
            if (result != null)
            {


                if (result == true)
                {
                    localMagazine.Isborrowed = Isborrowed.yes;
                    Indicatedtxt = "Borrowed";
                    flag = true;
                    GetDetails(memeberName);
                    

                }
                else if (result == false)
                {
                    flag= false;
                    Console.WriteLine("sorry to tell you but its borrowed");

                    

                }
            }
            return flag;

        }

        public static Magazine? Search(string name)
        {
            Magazine magazine = newListMagazine.FirstOrDefault(q => q.Title == name);
            if (magazine != null)
            {

                if (magazine.Isborrowed == Isborrowed.yes)
                {

                    return magazine;
                }
                else
                {
                    return magazine;

                }
            }
            else
            {

                return null;

            }

        }


        #endregion


    }
}
