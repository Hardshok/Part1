using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class InsertionSorter : Sorter
    {
        public InsertionSorter(int[] array) : base(array) { }


        public override void SortAscending()
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

        public override void SortDescending()
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
    }
}
