
using LMS.Enum.borrowcheck;
using System.Net.Http.Headers;
namespace LMS.Domains
{
    internal class Program
    {
        static Book book;
        static Magazine magazine1;
       static Member []membersarray=new Member[3];
     
        
   static Book[] books = new Book[5];
           static Magazine [] magazine = new Magazine[5];
           
             static List<Member> members = new List<Member>();
           static List<string>LibraryNameAndAdress= new List<string>();

        static void Main(string[] args)
        {
            startProgramm();
            
          
        }
        public  static void startProgramm() {
            Initializer();
           

            book = new Book(books);
            magazine1 = new Magazine(magazine);
            
                
            



















      
          


            Console.WriteLine("Welcome to Library Mangment System :");
            enterName:
                Console.WriteLine("Enter Member Name:");
            var username=Console.ReadLine();
            var result=Member.Search(username);
            if (result != null)
            {
              startpoint: 
              var userChoosing = 0;

                retry:
                Console.WriteLine("1)Borrow");
                Console.WriteLine("2)Return");
                Console.WriteLine("3)Exit");
                bool userInputValidate = int.TryParse(Console.ReadLine(), out userChoosing);
                if (userInputValidate)
                {
                    switch (userChoosing)
                    {
                        case 1:
                            {
                                BorrowBookOrMagazine(result.Name);
                                goto retry;
                                break;

                            }

                        case 2:
                            ReturnBookOrMagazine(result.Name);
                            goto retry;
                            
                            break;
                            case 3:break;
                       
                        default:
                            Console.WriteLine("ERROR!!!!!"); goto startpoint;

                    }


                }
                else
                {
                    Console.WriteLine("WRONG VALUE !!!!!");
                    Console.WriteLine("TRY AGAIN");
                    
                    goto startpoint;


                }
            }
            else {
                Console.WriteLine("YOUR NAME DOES NOT EXIST!!!!!");
                goto enterName;
            }
        
        
        }
        public static void BorrowBookOrMagazine(string memberName) {

        InvalidVal:
            Console.WriteLine("do you want to borrow a book or a magazine \n (1)to borrow  a book (2) to borrow a magazine ?");
            var userInput = 0;
            var flag = int.TryParse(Console.ReadLine(),out userInput );
            if (flag)
            {
                switch (userInput)
                {
                    case 1:
                        {
                            reTry:
                            Console.WriteLine("Enter The Book Name");
                            var bookname = Console.ReadLine();
                            var temp=book.Borrow(bookname, memberName);
                            if (temp == null)
                            {
                                Console.WriteLine("No Books are  Found");
                                goto reTry;

                            }
                            break;

                        }
                    case 2:
                        {
                            reEnter:
                            Console.WriteLine("enter magazine Name");
                            var magazineName = Console.ReadLine();
                            var temp2=magazine1.Borrow(magazineName, memberName);
                            if (temp2 == null) {
                                Console.WriteLine("No Magazines are  Found");
                                goto reEnter;

                            }
                            break;



                        }
                    default:
                        {
                            Console.WriteLine("you Entered Wrong Value");
                            goto InvalidVal;
                            break;

                        }
                }
            }
            else {
                Console.WriteLine("ENTER A VALID VALUE !!!!");
                goto InvalidVal;

            }


        }
        public static void ReturnBookOrMagazine(string name)
        {
            InvalidData:
            Console.WriteLine("do you want to return a book or a magazine \n (1)to return a book (2) to return a magazine ?");
            var userInput = 0;
            var flag = int.TryParse(Console.ReadLine(),out userInput );
            if (flag)
            {
                switch (userInput)
                {
                    case 1:
                        {
                            reEnterName:
                            Console.WriteLine("Enter The Book Name");
                            var bookname = Console.ReadLine();
                           var temp= book.Return(bookname, name);
                            if (temp == null)
                            {
                                Console.WriteLine("No books Found Try again");
                                goto reEnterName;
                            }
                            break;

                        }
                    case 2:
                        {
                            reEnterMagzine:
                            Console.WriteLine("Enter a Magazine Name");
                            var MagazineName = Console.ReadLine();
                           var temp2= magazine1.Return(MagazineName, name);
                            if (temp2 == null) {
                                Console.WriteLine("No Magazines are found Try again");
                                goto reEnterMagzine;

                            }
                            break;



                        }
                    default: {
                            Console.WriteLine("Invalid number");
                            goto InvalidData;

                        }
                }
            }
            else {
                Console.WriteLine("WRONG VALUE !!!!!!");
                goto InvalidData;


            }


        }
        public static void Initializer() {
            membersarray[0] = new Member() {Name="muhammad" };
            membersarray[0].setMemberId(3200101);
            membersarray[0].setEmail("muhammadhadidi1221@gmail.com");

            membersarray[1] = new Member() { Name = "mahmmoud" };
            membersarray[1].setMemberId(3200102);
            membersarray[1].setEmail("mahmoud2002@gmail.com");

            membersarray[2] = new Member() { Name = "tina" };
            membersarray[2].setMemberId(3200103);
            membersarray[2].setEmail("tinacs111@gmail.com.com");
            Member member = new Member(membersarray);



            books[0] = new Book()
            {
                Author = "Harper Lee",
                Genre = "Fiction, Coming-of-Age, Legal Drama",
                Isborrowed = Isborrowed.yes,
                NumberofPages = 281,
                PublishDate = " July 11, 1960",
                Title = "To Kill a Mockingbird",
            };
            books[0].setISBN("9781234567890");


            books[1] = new Book()
            {
                Author = "George Orwell",
                Isborrowed = Isborrowed.no,
                Genre = "Dystopian, Political Fiction, Science Fiction",
                NumberofPages = 328,
                PublishDate = "June 8, 1949",
                Title = "1984",
            };
            books[1].setISBN("9790123456789");

            books[2] = new Book()
            {
                Author = "F. Scott Fitzgerald",
                Isborrowed = Isborrowed.no,
                Genre = "Tragedy, Historical Fiction",
                NumberofPages = 180,
                PublishDate = "April 10, 1925",
                Title = "The Great Gatsby",
            };
            books[2].setISBN("9783567890123");


            books[3] = new Book()
            {
                Isborrowed = Isborrowed.yes,
                Author = "Jane Austen",
                Genre = "Romance, Satire",
                NumberofPages = 432,
                PublishDate = "January 28, 1813",
                Title = "Pride and Prejudice",
            };
            books[3].setISBN("9791987654321");


            books[4] = new Book()
            {
                Isborrowed = Isborrowed.yes,
                Author = "J.R.R. Tolkien",
                Genre = " Fantasy, Adventure",
                NumberofPages = 310,
                PublishDate = "September 21, 1937",
                Title = "The Hobbit",
            };
            books[4].setISBN("9780543210987");
            magazine[0] = new Magazine()
            {
                Title = "National Geographic",
                Author = "Susan Goldberg",
                Isborrowed = Isborrowed.yes,
                IssueNumber = 312,
                PublishDate = "October 1, 2023"




            };
            magazine[1] = new Magazine()
            {
                Title = "Time",
                Author = "Edward Felsenthal",
                Isborrowed = Isborrowed.no,
                IssueNumber = 38,
                PublishDate = "September 18, 2023"




            };
            magazine[1].setISBN("9780140449603");

            magazine[2] = new Magazine()
            {
                Title = "The New Yorker",
                Author = "David Remnick",
                Isborrowed = Isborrowed.no,
                IssueNumber = 28,
                PublishDate = " October 9, 2023"




            };
            magazine[2].setISBN("9780743273565");

            magazine[3] = new Magazine()
            {
                Title = "Wired",
                Author = "Gideon Lichfield",
                Isborrowed = Isborrowed.no,
                IssueNumber = 9,
                PublishDate = " September 22, 2023"




            };
            magazine[3].setISBN("9781566199094");
            magazine[4] = new Magazine()
            {
                Title = "American",
                Author = "Laura Helmuth",
                Isborrowed = Isborrowed.yes,
                IssueNumber = 11,
                PublishDate = " November 1, 2023"




            };
            magazine[4].setISBN("9780262033848");






        }
    }
}
