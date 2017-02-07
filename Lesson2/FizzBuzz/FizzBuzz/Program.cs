using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            Console.Title = "FizzBuzz";
            bool bFizz, bBuzz;
            for (int iNumber = 1; iNumber <= 100; iNumber++)
            {
                bFizz = iNumber % 3 == 0;
                bBuzz = iNumber % 5 == 0;
                if (bFizz && bBuzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (bFizz)
                {
                    Console.WriteLine("Fizz");
                }
                else if (bBuzz)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(iNumber);
                }
             }

            Console.ReadKey();
        }
    }
}
