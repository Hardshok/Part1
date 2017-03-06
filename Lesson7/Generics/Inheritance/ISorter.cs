using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface ISorter<T> : IPrintable    
    {
        void SortAscending();
        void SortDescending();
        void Swap(int index1, int index2);
    }
}
