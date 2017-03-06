using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class InsertionSorter<T> : Sorter<T>
    {
        public InsertionSorter(T[] array) : base(array) { }

        public override void SortAscending()
        {
            int iPrevious;
            for (int iCount = 1; iCount < ArrayOfObjects.Length; iCount++) {
                Comparable current = ArrayOfObjects[iCount];
                iPrevious = iCount - 1;                
                while (iPrevious >= 0 && current.CompareTo(ArrayOfObjects[iPrevious]) == - 1)
                {
                    Swap(iPrevious + 1, iPrevious);
                    iPrevious--;
                }
            }
        }

        public override void SortDescending()
        {
            int iPrevious;
            for (int iCount = 1; iCount < ArrayOfObjects.Length; iCount++) {
                Comparable current = ArrayOfObjects[iCount];
                iPrevious = iCount - 1;
                while (iPrevious >= 0 && current.CompareTo(ArrayOfObjects[iPrevious]) == 1)
                {
                    Swap(iPrevious + 1, iPrevious);
                    iPrevious--;
                }
            }
        }
    }
}
