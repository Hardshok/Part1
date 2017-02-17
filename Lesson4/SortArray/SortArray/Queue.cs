using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    public class Queue
    {
        /* 'Tail': start place in array to read
           'Head': place to which write new data */
        public int Tail, Head;
        static int Count;        

        public string[] InitQueue()
        {
            Console.Write("Enter the size of Queue: ");
            string[] Queue = new string[Program.ReadAndValidate(false)]; // 'false' arg. means Zero is not allowed as the size of the array                        
            Head = 0;
            Tail = 0;
            Count = 0;
            Console.WriteLine(" New Queue is created with size {0}", Queue.Length);
            return Queue;
        }
        
        static void Enqueue(string[] Stack, string sMessage)  //Put element in queue
        {

        }

        static string Dequeue(string[] Stack) //Get element from queue (through out parameter, true if element got from queue, false otherwise)
        {
            string sMessage = "";

            return sMessage;
        }

        static bool IsEmpty() //Return true if buffer is empty
        {
            bool IsEmpty;            
            IsEmpty = ( Count == 0) ? true : false;
            return IsEmpty;
        }

        static bool IsFull(string[] userQueue) //Return true if buffer is full
        {
            bool IsFull;
            IsFull = (Count == userQueue.Length) ? true : false;
            return IsFull;
        }
    }
}
