using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuAIS.Task2.isleap
{
    public class Date
    {
        #region Fields 
        private int _day;
        private int _month;
        private int _year;
        private int _anotheryear;
        public bool fflag;

        #endregion
        #region Proproties 
        public int AnotherYear { get { return _anotheryear; }
            
            set { _anotheryear = value; } }
        public int Day
        {
            get
            {
                return _day;

            }
            set
            {
                _day = value;
            }
        }
        public int Month
        {
            get
            {
                return _month;

            }
            set { _month = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }


        #endregion
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
           

        }
        public Date(int year1, int year2)
        {
            Year = year1;
            AnotherYear = year2;

            
        }

        public  bool? datanumberValidate()
        {
            int[] normalyearMonths = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] leapyearMonths = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            bool monthDaycheck;
            var exp1 = Year >= 1900 && Year <= 2024;
            var exp2 = Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0;
            if (exp1 && exp2)
            {
               monthDaycheck= MonthDayChecker(leapyearMonths);
                if (monthDaycheck)
                {
                    Console.Write($"{Day}/{Month}/{Year}  ");

                    return true;


                }
                else {
                    return null;
                }
              




            }
            else
            {
                  
                
                    monthDaycheck = MonthDayChecker(normalyearMonths);
                    if (monthDaycheck)
                    {
                        Console.WriteLine("Normal Year");
                        Console.Write($"{Day}/{Month}/{Year}  ");
                        return false;

                    }
                    else
                    {
                       


                        return null;
                    }
                   


                

            }








            return false;

        }
        public bool MonthDayChecker(int[] monthsdays)
        {



            if (Month >= 1 && Month <= 12)
            {
                if (monthsdays[Month] >= Day)
                {
                    return true;

                }
                else
                {
                    return false;

                }

            }
            else
            {
                return false;

            }








        }
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

