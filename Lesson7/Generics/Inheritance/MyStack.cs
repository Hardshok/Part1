using System;

namespace Generics
{
    public class MyStack<T> : Buffer<T>, IMyStack<T>
    {
        /* 'head': start place in array to read
         * 'tail': place to which write new data */

        protected int top;

        public MyStack(int userSize)
            : base(userSize)
        {
            top = -1;
            Console.WriteLine(" New Stack is created with size {0}", buffer.Length);
        }

        public void Push(T item)
        {
            if (!this.IsFull())
                buffer[++top] = item;
            else
                MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "\nStack is full. To add new element do 'Pop' first");
        }

        public T Pop()
        {
            T item = default(T);
            if (!this.IsEmpty())
            {
                item = buffer[top--];
                //buffer[top + 1] = ""; //just make item to be empty
                return item;
            }
            else
                MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "\nStack is EMPTY. To get top element do 'Push' first");           
            return item;
        }

        public T Peek()
        {
            //string item = "";
            T item = default(T);
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
