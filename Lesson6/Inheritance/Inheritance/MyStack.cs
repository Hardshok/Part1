using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class MyStack : Buffer
    {
        /* 'head': start place in array to read
         * 'tail': place to which write new data */
        
        //private string[] stack;        
        protected int top;

        public MyStack(int userSize) : base (userSize)
        {
            //Init();
            top = -1;
            Console.WriteLine(" New Stack is created with size {0}", buffer.Length);
        }

        public void Push(string item)
        {
            if (!IsFull())
                buffer[++top] = item;
            else
                MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "\nStack is full. To add new element do 'Pop' first");
        }

        public string Pop()
        {
            string item = "";
            if (!IsEmpty()) {
                item = buffer[top--];
                buffer[top + 1] = "";
            }
            else
                MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "\nStack is EMPTY. To get top element do 'Push' first");
            return item;
        }

        public string Peek()
        {
            string item = "";
            if (!IsEmpty())
                item = buffer[top];
            else
                MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "\nStack is EMPTY. To get top element do 'Push' first");
            return item;
        }
        
        public override bool IsEmpty()
        {
            bool isEmpty;
            isEmpty = (top < 0) ? true : false;
            return isEmpty;
        }

        public override bool IsFull()
        {
            bool isFull;
            isFull = (top == buffer.Length - 1) ? true : false;
            return isFull;
        }

        public override void Print()
        {
            Console.Write("Now Stack is: ");
            string Sum = "";
            for (int iCount = 0; iCount <= top; iCount++)
                Sum += buffer[iCount] + "; ";
            MyServiceFunctions.WriteColorLine(ConsoleColor.Green, "[ " + Sum + "]");
        }
    }
}
