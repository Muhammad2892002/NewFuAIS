
using FuAIS.Task2.isleap;
using Microsoft.VisualBasic;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Initializer();


        }
        static void start() {
            Console.WriteLine("welcome to is leap or not\n");
            bool tempf1, tempf2, tempf3;
            int tempday, tempmonth, tempyear;
            bool? dd = null;


            Console.WriteLine("enter a day ");
            tempf1 = int.TryParse(Console.ReadLine(), out tempday);

            Console.WriteLine("enter a month ");
            tempf2 = int.TryParse(Console.ReadLine(), out tempmonth);

            Console.WriteLine("enter a year ");
            tempf3 = int.TryParse(Console.ReadLine(), out tempyear);
            var result = checkingDatetxt(tempf1, tempf2, tempf3);
            if (result) {
                Date date = new Date(tempday, tempmonth, tempyear);
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
                    Initializer();

                }
                else if (userAnswerChar == 'n' || userAnswerChar == 'N')
                {
                    Environment.Exit(0);

                }
                else { Console.WriteLine("enter valid Data"); }
                
                



            }
            else {
                Console.WriteLine("ENTER VALID VALUE !!!!!");
                Initializer();



            }





        }
        public static void Initializer() {
            Console.WriteLine($"Welcome to leap year \n if you want to know the leap years press\"0\" \nOr press \"1\"if you " +
              $"want to enter specific date ");
            UserSelectionValidation();





        }

        public static bool checkingDatetxt(bool day, bool month, bool year) {
            var inResult = day && month && year;

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
