using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {        
        protected int head, tail, count;

        public MyQueue(int userSize) : base (userSize)
        {            
            head = tail = count = 0;
            Console.WriteLine(" - Empty buffer is created with size {0}", buffer.Length);
        }

        public void Enqueue(T item)  //Write element in queue
        {            
            if (!IsFull()) {
                buffer[tail++] = item;
                if (tail == buffer.Length)
                    tail = 0;
                count++;
            }
            else
                MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "\nQueue is FULL. To write new element do 'Dequeue' first");
        }

        //Remove from queue (through out parameter, true if element got from queue, false otherwise)
        //public bool Dequeue(out string queueItem)
        public bool Dequeue(out T queueItem)
        {
            //queueItem = "";
            queueItem = default(T);
            bool bResult = false;
            if (!IsEmpty()) {
                queueItem = buffer[head++];
                if (head == buffer.Length)
                    head = 0;
                count--;
                bResult = true;
            }
            else
                MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "\nQueue is EMPTY. Write new element first ('Enqueue')");
            return bResult;
        }

        public override bool IsEmpty()
        {
            bool IsEmpty;
            IsEmpty = (count == 0) ? true : false;
            return IsEmpty;
        }

        public override bool IsFull()
        {
            bool IsFull;
            IsFull = (count == buffer.Length) ? true : false;
            return IsFull;
        }

        public override void Print()
        {
            Console.WriteLine("\nNow cycle buffer is:");
            for (int iCount = 0; iCount < buffer.Length; iCount++) {
                if (head == iCount)
                    Console.Write("              <-- head");
                if (tail == iCount)
                    Console.Write("              <-- tail");
                MyServiceFunctions.WriteColorLine(ConsoleColor.Green, "\r  Item " + iCount + ": " + buffer[iCount]);
            }
        }
    }
}
