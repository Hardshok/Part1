using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    interface IMyStack<T> : IBuffer<T>
    {        
        void Push(T item);
        T Pop();
        T Peek();
    }
}
