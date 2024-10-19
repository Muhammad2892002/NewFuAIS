using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuAIS.Task2.isleap
{
    public class Date
    {
        #region Data Fields 
      
        private int _year;
        private int _anotheryear;
        public bool fflag;

        #endregion
        #region Proproties 
        public int AnotherYear { get { return _anotheryear; }
            
            set { _anotheryear = value; } }
       
      
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }


        #endregion

        /// <summary>
        /// A constructer that accepts Three parameters
        /// 
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// 
        #region Constructers
        public Date( int year)
        {
          
            Year = year;
           

        }
        /// <summary>
        /// A constructer contains Two Parameyers
        /// </summary>
        /// <param name="year1"></param>
        /// <param name="year2"></param>
        public Date(int year1, int year2)
        {
            Year = year1;
            AnotherYear = year2;

            
        }
        #endregion

        /// <summary>
        /// To check if the entered   leap Date or something doesnt make sence or normal Year 
        /// </summary>
        /// <returns></returns>
        /// 
        #region Methods

        public bool? datanumberValidate()
        {
           
            
            var exp1 = Year >= 1900 && Year <= 2024;
            var exp2 = Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0;
            if (exp1 && exp2)
            {

                Console.Write($"{Year}");

                return true; 

            }
            else
            {
                  
                
                    
                    if (Year>=0&&Year<=2024)
                    {
                    return false;
                    }
                    else
                    {
                        return null;
                    }
            }

            return false;

        }
      
    
        /// <summary>
        /// this method helps tp print all leap year after the user gave a year range
        /// </summary>
        public void LeapYears() {
            bool yearchecker;
            int counter = 1;
            if (Year >= 0 && AnotherYear <= 2024 && Year < AnotherYear)
            {
                for (; Year >= 0 && Year <= AnotherYear; Year++)
                {

                    yearchecker = Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0;
                    if (yearchecker)
                    {
                        Console.WriteLine($"({counter})({Year})\n");
                        counter++;
                    }



                }
            }
            else {
                Console.WriteLine("You entred Wrong data");

            }

        
        
        }

    }
}

#endregion
