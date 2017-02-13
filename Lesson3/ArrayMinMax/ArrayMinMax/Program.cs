using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of array:");
            int[] userArray = new int[ReadAndValidate(false)]; // 'false' arg. means Zero is not allowed as the size of the array

            Console.WriteLine("\nEnter the array's elements (each number to separate by Enter):");
            for (int iCount = 0; iCount < userArray.Length; iCount++)
                userArray[iCount] = ReadAndValidate();

            int arrayMin = userArray[0];
            int arrayMax = arrayMin;
            for (int iCount = 1; iCount < userArray.Length; iCount++)
            {
                if (userArray[iCount] < arrayMin)
                    arrayMin = userArray[iCount];
                if (userArray[iCount] > arrayMax)
                    arrayMax = userArray[iCount];
            }
            Console.WriteLine("\nMinimum of the array is {0}", arrayMin);
            Console.WriteLine("Maximum of the array is {0}", arrayMax);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        //ReadLine() + validate that the entered value is: not a string; not empty, not out of the integer range; not 0 (if isZeroAllowed=True)
        static int ReadAndValidate(bool isZeroAllowed=true)
        {
            int iLine;
            if (!isZeroAllowed) //entering '0' is not allowed
            {
                while (Int32.TryParse(Console.ReadLine(), out iLine) == false || iLine == 0)
                    Console.WriteLine("The value is equal '0', not a number or out of the range. Enter it again:");
            }
            else
            {
                while (Int32.TryParse(Console.ReadLine(), out iLine) == false)
                    Console.WriteLine("The value is not a number or out of the range. Try to enter it again:");
            }
            return iLine;
        }
    }
}

