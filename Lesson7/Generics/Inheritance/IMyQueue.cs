using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    interface IMyQueue<T> : IBuffer<T>
    {
        void Enqueue(T item);
        bool Dequeue(out T item);
    }
}
