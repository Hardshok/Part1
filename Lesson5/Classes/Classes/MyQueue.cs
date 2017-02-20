﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class MyQueue
    {
        private string[] buffer;
        public int size, head, tail, count;

        public MyQueue(int userSize)
        {
            size = userSize;
            Init();
        }

        public void Init()
        {            
            buffer = new string[size];
            head = tail = count = 0;
            Console.WriteLine(" - Empty buffer is created with size {0}", buffer.Length);            
        }

        public void Enqueue(string item)  //Write element in queue
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
        public bool Dequeue(out string queueItem)
        {
            queueItem = "";
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

        public bool IsEmpty() //Return true if buffer is empty
        {
            bool IsEmpty;
            IsEmpty = (count == 0) ? true : false;
            return IsEmpty;
        }

        public bool IsFull() //Return true if buffer is full
        {
            bool IsFull;
            IsFull = (count == buffer.Length) ? true : false;
            return IsFull;
        }

        public void Print()
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
