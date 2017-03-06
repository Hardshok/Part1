using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public abstract class Buffer<T> : IBuffer<T>
    {
        //public T[] buffer;
        protected T[] buffer;
        public abstract bool IsEmpty();
        public abstract bool IsFull();        
        public abstract void Print();

        public Buffer(int userSize)
        {            
            buffer = new T[userSize];
        }
    }
}
