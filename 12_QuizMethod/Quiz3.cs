using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _12_QuizMethod
{
    [TestClass]
    public class Quiz3
    {


        [TestMethod]
        public void Q8()
        {
            int number;
            string numberStr = "123456";
             Console.WriteLine(number);
            

        }

        [TestMethod]
        public void Q9()
        {
            int x = 10;
            int r= 5;
            int y=0;
           
            Console.WriteLine( y= x / r);
            double vOut = Convert.ToDouble(y);

        }



        [TestMethod]
        public void Q10()
        {
            string name = "Tulha alsalah";
            Console.WriteLine("Hello" + name);
              
            

        }


        [TestMethod]
        public void YearsOld()
        {
            int birthyear = 1985; int age= 2020; 
            //Console.Write("Enter Year you were born ");
            //birthyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birth year is "  + birthyear);
            Console.WriteLine("age is" + (age- birthyear));

        }



        [TestMethod]
        public void MaxNumber()
        {
            //Console.Write("First Number= ");
            //Console.Write("Second Number =");
            int first = 10;
            int second = 13;

            if (first > second)
            {
                Console.WriteLine(first);
            }
            else if (first < second)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine("Both Numbers are equal!");
            }

        }
    
    



        [TestMethod]
        public void FizzBuzzQ5()
        {
            int n = 50;
            for (int i=1;i<=n;i++)
            {

                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz ");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

              //  else if (i % 3 == 0 && i % 5 == 0)
                  /*  else if (i % 15 == 0)
                        {
                    Console.WriteLine("FizzBuzz" );
                }*/

                else
                {
                    Console.WriteLine(i);
                }

            }


        }

        
    }
}
