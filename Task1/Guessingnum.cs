using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber

{


    public class Guessingnum
    {


        #region Varibles sec
        public static int choosedNumber = 0;
        public static int randomNum = 0;
        public static bool NumOrTxt;
        public static int AttemptsNum = 0;
        public static bool PlayAgain = false;
        public static bool flag = true;
        #endregion
        #region Methods Sec
        /// <summary>
        /// this method is used to start the game,it is essential to play this game.
        /// 
        /// 
        /// </summary>
        public static void Initialize()
        {
            choosedNumber = 0;
            randomNum = 0;
            NumOrTxt = false;
            AttemptsNum = 0;
            PlayAgain = false;
            Random random = new Random();
            randomNum = random.Next(1, 5);
        Again:

            Console.WriteLine("Welcome to guess Game");
            Console.WriteLine("Enter a number between 1 to 100");
        NotAccepted:
            NumOrTxt = int.TryParse(Console.ReadLine(), out choosedNumber);
            if (NumOrTxt)
            {

                Guessingnum guessingnum = new Guessingnum();
                var checking = guessingnum.checkingNumber(choosedNumber);
                if (checking)
                {
                    string value = guessingnum.Game(choosedNumber);
                    Console.WriteLine(value);

                }
                else
                {
                    Console.WriteLine("Enter A number Between 1 to 100");
                    goto NotAccepted;

                }



            }
            else
            {
                Console.WriteLine("Enter Valid Number Not A text ");
                goto Again;


            }








        }
        /// <summary>
        /// to check if the number is valid or not
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>returns true if the number is between 1 to 100 and returns false if the number smaller than or greater 
        /// than the conditions</returns>
        public bool checkingNumber(int number)
        {
            if (number > 1 && number <= 100)
            {
                return true;


            }
            else
            {
                return false;

            }



        }
        /// <summary>
        /// this method is used for guessing game 
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>returns string after you put the right number</returns>

        public string Game(int value)
        {
            flag = true;
            while (flag)
            {
                AttemptsNum++;
                if (choosedNumber == randomNum)
                {
                    Console.WriteLine("You Win !");
                    Console.WriteLine($"your total Attempts is :{AttemptsNum}");
                notlogicanswer:
                    Console.WriteLine("Do you want to play Again(Y/N)");
                    var retry = Console.ReadLine().ToUpper();
                    char alpha = retry[0];
                    switch (alpha)
                    {
                        case 'Y': Guessingnum.Initialize(); break;
                        case 'N': flag = false; break;
                        default:
                            Console.WriteLine("Enter Valid Symbol"); goto notlogicanswer; break;


                    }


                }
                else
                {
                    if (choosedNumber > randomNum)
                    {
                        Console.WriteLine("Its Too High");
                        NumOrTxt = int.TryParse(Console.ReadLine(), out choosedNumber);

                    }
                    else if (choosedNumber < randomNum)
                    {
                        Console.WriteLine("Its Too Low");
                        NumOrTxt = int.TryParse(Console.ReadLine(), out choosedNumber);


                    }




                }
            }
            if (!flag)
            {

                return "ok good bye .......";
            }

            return "ERROR - -";



        }
        #endregion

    }
}

