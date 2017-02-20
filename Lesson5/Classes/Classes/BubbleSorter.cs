using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class BubbleSorter
    {
        private int[] myArray;
        private int buffer;
        
        public BubbleSorter(int[] array)
        {
            myArray = array;
        }

        public void SortAscending()
        {
            bool b;
            do {
                b = false;
                for (int iCount = 0; iCount < myArray.Length - 1; iCount++) {
                    int iNext = iCount + 1;
                    if (myArray[iCount] > myArray[iNext]) {
                        Swap(iCount, iNext);
                        b = true;
                    }
                }
            } while (b);
        }

        public void SortDescending()
        {
            bool b;
            do {
                b = false;
                for (int iCount = 0; iCount < myArray.Length - 1; iCount++) {
                    int iNext = iCount + 1;
                    if (myArray[iCount] < myArray[iNext]) {
                        Swap(iCount, iNext);
                        b = true;
                    }
                }
            } while (b);
        }

        public void Swap(int argIndex1, int argIndex2)
        {
            buffer = myArray[argIndex1];
            myArray[argIndex1] = myArray[argIndex2];
            myArray[argIndex2] = buffer;
        }

        public void PrintArray()
        {
            Console.WriteLine("Array is:");
            string Sum = " ";
            for (int iCount = 0; iCount < myArray.Length; iCount++)
                Sum += myArray[iCount] + "; ";
            MyServiceFunctions.WriteColorLine(ConsoleColor.Green, Sum);
        }
    }
}
