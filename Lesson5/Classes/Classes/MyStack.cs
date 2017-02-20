using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class MyStack
    {
        /* 'head': start place in array to read
         * 'tail': place to which write new data */
        private string[] stack;
        private int size, top;

        /* Q: Maybe there is better to use:
         * public int Size {set { size = value } } */
        public MyStack(int userSize)
        {
            size = userSize;
            Init();
        }

        public void Init()
        {            
            stack = new string[size];
            top = -1;
            Console.WriteLine(" New Stack is created with size {0}", stack.Length);
            //return stack;
        }

        public void Push(string item)
        {
            if (!IsFull())
                stack[++top] = item;
            else
                MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "\nStack is full. To add new element do 'Pop' first");
        }

        public string Pop() // Get the item and then removed it from the stack
        {
            string item = "";
            if (!IsEmpty()) {
                item = stack[top--];
                stack[top + 1] = "";
            }
            else
                MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "\nStack is EMPTY. To get top element do 'Push' first");
            return item;
        }

        public string Peek()  //Get top element without removing it from the Stack
        {
            string item = "";
            if (!IsEmpty())
                item = stack[top];
            else
                MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "\nStack is EMPTY. To get top element do 'Push' first");
            return item;
        }
        
        public bool IsEmpty()
        {
            bool isEmpty;
            isEmpty = (top < 0) ? true : false;
            return isEmpty;
        }

        public bool IsFull()
        {
            bool isFull;
            isFull = (top == stack.Length - 1) ? true : false;
            return isFull;
        }

        public void Print()
        {
            Console.Write("Now Stack is: ");
            string Sum = "";
            for (int iCount = 0; iCount <= top; iCount++)
                Sum += stack[iCount] + "; ";
            MyServiceFunctions.WriteColorLine(ConsoleColor.Green, "[ " + Sum + "]");
        }
    }
}
