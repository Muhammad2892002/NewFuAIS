using GuessTheNumber;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    public class Program
    {
        private  static int[] num={10,20,30,40,50};
        public  delegate void FirstDelegate(int delegateVal);
        public int this[int index] {
            get {  return num[index]; }
            set { num[index] = value; }
        }
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                var numbb = 0;
                Console.WriteLine("enter a number between 0-4");
                var value = int.TryParse(Console.ReadLine(), out numbb);
                if (value)
                {
                    if (numbb < num.Length)
                    {
                        Program program = new Program();
                        FirstDelegate first = program.Search;
                        first(numbb);
                        flag=false;
                    }
                   
                }
                else
                {
                    Console.WriteLine("its not logic");
                    


                }
            }
            //Guessingnum.Initialize();
            
        }
        public  void Search(int value) { 
            Program program= new Program();
            Console.WriteLine($"The  Value is :{program[value]}<-----------");





        }
    }
}
