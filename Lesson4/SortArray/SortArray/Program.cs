using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
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
                        
            //BubbleSortAscending(userArray);
            BubbleSortDescending(userArray);       

            Console.WriteLine("\nPress any key to exit...");
            
            Console.ReadKey();
        }

        //ReadLine() + validate that the entered value is: not a string; not empty, not out of the integer range; not 0 (if isZeroAllowed=True)
        static int ReadAndValidate(bool isZeroAllowed = true)
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

        static void Swap(int[] argArray, int argIndex1, int argIndex2)
        {            
            int iBuffer = argArray[argIndex1];
            argArray[argIndex1] = argArray[argIndex2];
            argArray[argIndex2] = iBuffer;            
        }

        static void BubbleSortAscending(int[] argArray) //Bubble sorting - Ascending
        {
            bool b;
            do { 
                b = false;
                for (int iCount = 0; iCount < argArray.Length - 1; iCount++)
                {
                    int iNext = iCount + 1;
                    if (argArray[iCount] > argArray[iNext])
                    { 
                        Swap(argArray, iCount, iNext);
                        b = true;
                    }
                }
            } while (b);
        }

        static void BubbleSortDescending(int[] argArray) //Bubble sorting - Descending
        {
            bool b;
            do {
                b = false;
                for (int iCount = 0; iCount < argArray.Length - 1; iCount++)
                {
                    int iNext = iCount + 1;
                    if (argArray[iCount] < argArray[iNext])
                    {
                        Swap(argArray, iCount, iNext);
                        b = true;
                    }
                }
            } while (b);
        }

    }
}
