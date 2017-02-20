using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class InsertionSorter
    {
        private int[] myArray;
        private int buffer;

        public InsertionSorter(int[] array)
        {
            myArray = array;
        }

        public void SortAscending()
        {
            int iCurrent, iPrevious;
            for (int iCount = 1; iCount < myArray.Length; iCount++) {
                iCurrent = myArray[iCount];
                iPrevious = iCount - 1;
                while (iPrevious >= 0 && iCurrent < myArray[iPrevious])
                {
                    Swap(iPrevious + 1, iPrevious);
                    iPrevious--;
                }
            }
        }

        public void SortDescending()
        {
            int iCurrent, iPrevious;
            for (int iCount = 1; iCount < myArray.Length; iCount++) {
                iCurrent = myArray[iCount];
                iPrevious = iCount - 1;
                while (iPrevious >= 0 && iCurrent > myArray[iPrevious])
                {
                    Swap(iPrevious + 1, iPrevious);
                    iPrevious--;
                }
            }
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
