using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class BubbleSorter<T> : Sorter<T>
    {
        public BubbleSorter(T[] array) : base(array) { }        
        
        public override void SortAscending()
        { 
            bool b;            
            do {
                b = false;                
                for (int iCount = 0; iCount < ArrayOfObjects.Length - 1; iCount++) {
                    int iNext = iCount + 1;                                  
                    if (ArrayOfObjects[iCount].CompareTo(ArrayOfObjects[iNext]) == 1) {
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
                for (int iCount = 0; iCount < ArrayOfObjects.Length - 1; iCount++) {
                    int iNext = iCount + 1;
                    if (ArrayOfObjects[iCount].CompareTo(ArrayOfObjects[iNext]) == -1) {
                        Swap(iCount, iNext);
                        b = true;
                    }
                }
            } while (b);
        }        
    }
}
