using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Sorter
    {
        protected int[] myArray;        

        public Sorter(int[] array)
        {
            myArray = array;
        }

        public virtual void SortAscending() { }

        public virtual void SortDescending() { }       

        public void Swap(int index1, int index2)
        {
            int buffer = myArray[index1];
            myArray[index1] = myArray[index2];
            myArray[index2] = buffer;
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
