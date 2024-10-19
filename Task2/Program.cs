
using FuAIS.Task2.isleap;
using Microsoft.VisualBasic;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            StartInitializing();


        }
        /// <summary>
        /// If the user entered "1" it will goes here and check if the specific date valid or not,and if its leap or not.
        /// </summary>
        static void start() {
            Console.WriteLine("welcome to is leap or not\n");
            bool tempf1, tempf2, tempf3;
            int tempday, tempmonth, tempyear;
            bool? dd = null;
       
            Console.WriteLine("enter a year ");
            tempf3 = int.TryParse(Console.ReadLine(), out tempyear);
            var result = checkingDatetxt( tempf3);
            if (result) {
                Date date = new Date( tempyear);
                dd = date.datanumberValidate();

                if (dd == true) {
                    Console.WriteLine("its leap");
                }

                else
                {
                    if (dd == false)
                        Console.WriteLine("not Leap");

                    else { Console.WriteLine("You Entered Wrong Value \ntry again "); start(); }
                }
            }

        }
        /// <summary>
        /// to check if the user entered a right value, and goes to list all leap years or to check a specific date is a leap
        /// depends on his chooise 0/1 and try again if he wants.
        /// </summary>
        public static void UserSelectionValidation() {
            var userEnteredChoise = 0;
            bool userChoiseValdition = false;
            var userAnswerStr="mm";
            char userAnswerChar;

            userChoiseValdition = int.TryParse(Console.ReadLine(), out userEnteredChoise);
            if (userChoiseValdition)
            {
                switch (userEnteredChoise) {
                    case 0:leapyears(); break;
                    case 1: start(); break;
                        default:
                        Console.WriteLine("wrong Value");UserSelectionValidation();break;
                }
                Console.WriteLine($"do you  want to try again(Y/N) ");
               
                ConsoleKeyInfo key = Console.ReadKey();
                userAnswerChar=key.KeyChar;
                if (userAnswerChar == 'y' || userAnswerChar == 'Y')
                {
                    StartInitializing();
                }
                else if (userAnswerChar == 'n' || userAnswerChar == 'N')
                {
                    Environment.Exit(0);
                }
                else { Console.WriteLine("enter valid Data"); }            
            }
            else {
                Console.WriteLine("ENTER VALID VALUE !!!!!");
                StartInitializing();
            }





        }
        /// <summary>
        /// starting a programm by this method
        /// </summary>
        public static void StartInitializing() {
            Console.WriteLine($"Welcome to leap year \n if you want to know the leap years press\"0\" \nOr press \"1\"if you " +
              $"want to enter specific date ");
            UserSelectionValidation();





        }
        /// <summary>
        /// to check if the entred date are valid or not
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns>all parameters returns booolean</returns>

        public static bool checkingDatetxt( bool year) {
            var inResult = year;

            if (inResult)
            {
                return true;
            }
            else {
                Console.WriteLine("Please enter valid Date");
                start();
                return false;
            }




        }
        /// <summary>
        /// the user must enter valid leap  years otherwise the programm will not accept the entered value
        /// if it is true it will send the value as arrgument to Date Constructer ,and by the date obj LeapYearsMethod will be 
        /// called.
        /// </summary>

        public static void leapyears(){
            int year1, year2;
            bool firstYearValidate, secondYearValidate;
            Console.WriteLine("Enter The First Year");
            firstYearValidate=int.TryParse(Console.ReadLine(), out year1);
            Console.WriteLine("Enter The Second Year");
            secondYearValidate = int.TryParse(Console.ReadLine(), out year2);
            if (firstYearValidate && secondYearValidate)
            {
                Date date = new Date(year1, year2);
                date.LeapYears();
            }
            else {
                Console.WriteLine("Invalid Data \n try again\n");
                leapyears();
            
            
            }




        }

    

            
        
        
        
        
    }
}
