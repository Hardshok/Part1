using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BubbleSorter : Sorter
    {
        public BubbleSorter(int[] array) : base(array) { }        
        
        public override void SortAscending()
        { 
            bool b;
            do {
                b = false;
                for (int iCount = 0; iCount < myArray.Length - 1; iCount++)
                {
                    int iNext = iCount + 1;
                    if (myArray[iCount] > myArray[iNext])
                    {
                        Swap(iCount, iNext);
                        b = true;
                    }
                }
            } while (b);
        }

        public override void SortDescending()
        {
            bool b;
            do {
                b = false;
                for (int iCount = 0; iCount < myArray.Length - 1; iCount++)
                {
                    int iNext = iCount + 1;
                    if (myArray[iCount] < myArray[iNext])
                    {
                        Swap(iCount, iNext);
                        b = true;
                    }
                }
            } while (b);
        }        
    }
}
