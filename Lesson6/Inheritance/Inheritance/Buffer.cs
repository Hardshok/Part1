using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Buffer
    {
        public string[] buffer;
        
        public Buffer(int userSize)
        {            
            buffer = new string[userSize];
        }

        public virtual bool IsEmpty()
        {
            bool isEmpty;
            isEmpty = (buffer.Length == 0) ? true : false;
            return isEmpty;
        }

        public virtual bool IsFull()
        {
            bool isFull;
            isFull = (buffer.Length > 0) ? true : false;
            return isFull;
        }

        public virtual void Print()
        {
            Console.Write("Actual Buffer is: ");
            string Sum = "";
            for (int iCount = 0; iCount < buffer.Length; iCount++)
                Sum += buffer[iCount] + "; ";
            MyServiceFunctions.WriteColorLine(ConsoleColor.Green, "[ " + Sum + "]");
        }

    }
}
