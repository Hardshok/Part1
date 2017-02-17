using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{    
    class Program
    {
        static int top = -1;

        static void Main()
        {
            Console.Title= "SORT ARRAY - Buble and Insertion Sorting";
            Console.SetWindowSize(80,50);

            //realise swith to sorting ot stack here !!

            int[] userArray = InitArray();  
            bool bRepeat=false;
            do {       // user can select sorting method again
                WriteColorLine(ConsoleColor.Yellow, "\nSort method:\n 1 = Bubble sorting by Ascending\n 2 = Bubble sorting by Descending");
                WriteColorLine(ConsoleColor.Yellow, " 3 = Insertion Sort by Ascending\n 4 = Insertion Sort by Descending"); 
                Console.Write("Please enter your selection: ");
                int iVariant = ReadAndValidate(false);
                switch (iVariant)
                {
                    case 1:
                        WriteColorLine(ConsoleColor.Blue, "\n***Bubble sorting by Ascending***");
                        int[] Array1 = userArray;
                        BubbleSortAscending(Array1);
                        PrintArray(Array1);
                        break;
                    case 2:
                        WriteColorLine(ConsoleColor.Blue, "\n***Bubble sorting by Descending***");
                        int[] Array2 = userArray;
                        BubbleSortDescending(Array2);
                        PrintArray(Array2);
                        break;
                    case 3:
                        WriteColorLine(ConsoleColor.Blue, "\n***Insertion sort by Ascending***");
                        int[] Array3 = userArray;
                        InsertionSortAscending(Array3);
                        PrintArray(Array3);
                        break;
                    case 4:
                        WriteColorLine(ConsoleColor.Blue, "\n***Insertion sort by Descending***");
                        int[] Array4 = userArray;
                        InsertionSortDescending(Array4);
                        PrintArray(Array4);
                        break;
                    case 5:
                        bool bAction = false;
                        Console.Clear();
                        WriteColorLine(ConsoleColor.Blue, "\n***Implement Stack***");
                        string[] userStack = StackInit();
                        do { //user can repeat operations with stack
                            WriteColorLine(ConsoleColor.Yellow, "\n 1 = Push Stack\n 2 = Pop Stack\n 3 = Pick");                            
                            Console.Write("Please select operation for your stack: ");
                            int iOperation = ReadAndValidate(false);
                            switch (iOperation)
                            {
                                case 1: //Push                               
                                    Console.Write("Enter string to Push: ");
                                    StackPush(userStack, Console.ReadLine());                                    
                                    break;
                                case 2: //Pop
                                    break;
                                case 3: // Pick
                                    break;
                                case 4:
                                    break;
                                case 5:
                                    break;
                                default:
                                    WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, or 4");
                                    break;
                            }
                            bAction = IsRepeat();
                        } while (bAction);
                        break;
                    case 6:
                        WriteColorLine(ConsoleColor.Blue, "\n***Implement Circular Buffer Queue***");
                        break;
                    default:
                        WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, or 4");
                        break;
                }
                bRepeat = IsRepeat();
            } while (bRepeat);

            WriteColorLine(ConsoleColor.White, "Press any key to exit...");
            Console.ReadKey();
        }
        
        static void BubbleSortAscending(int[] argArray) //Bubble sorting - Ascending
        {
            bool b;
            do { 
                b = false;
                for (int iCount = 0; iCount < argArray.Length - 1; iCount++)
                {
                    int iNext = iCount + 1;
                    if (argArray[iCount] > argArray[iNext])
                    { 
                        Swap(argArray, iCount, iNext);
                        b = true;
                    }
                }
            } while (b);
        }

        static void BubbleSortDescending(int[] argArray) //Bubble sorting - Descending
        {
            bool b;
            do {
                b = false;
                for (int iCount = 0; iCount < argArray.Length - 1; iCount++)
                {
                    int iNext = iCount + 1;
                    if (argArray[iCount] < argArray[iNext])
                    {
                        Swap(argArray, iCount, iNext);
                        b = true;
                    }
                }
            } while (b);
        }

        static void InsertionSortAscending(int[] argArray)
        {
            int iCurrent, iPrevious;
            for (int iCount = 1; iCount < argArray.Length; iCount++)
            {
                iCurrent = argArray[iCount];
                iPrevious = iCount - 1;
                while (iPrevious >= 0 && iCurrent < argArray[iPrevious])
                {
                    Swap(argArray, iPrevious+1, iPrevious);
                    iPrevious--;
                }                
            }
        }

        static void InsertionSortDescending(int[] argArray)
        {
            int iCurrent, iPrevious;
            for (int iCount = 1; iCount < argArray.Length; iCount++)
            {
                iCurrent = argArray[iCount];
                iPrevious = iCount - 1;
                while (iPrevious >= 0 && iCurrent > argArray[iPrevious])
                {
                    Swap(argArray, iPrevious + 1, iPrevious);
                    iPrevious--;
                }
            }
        }

        static void Swap(int[] argArray, int argIndex1, int argIndex2)
        {
            int iBuffer = argArray[argIndex1];
            argArray[argIndex1] = argArray[argIndex2];
            argArray[argIndex2] = iBuffer;
        }

        //ReadLine() + validate that the entered value is: not a string; not empty, not out of the integer range; not 0 (if isZeroAllowed=True)
        static int ReadAndValidate(bool isZeroAllowed = true)
        {
            int iLine;
            if (!isZeroAllowed) //entering '0' is not allowed
            {
                while (Int32.TryParse(Console.ReadLine(), out iLine) == false || iLine == 0)
                    WriteColorLine(ConsoleColor.Red, "The value is equal '0', not a number or out of the range. Enter it again:");
            }
            else
            {
                while (Int32.TryParse(Console.ReadLine(), out iLine) == false)
                    WriteColorLine(ConsoleColor.Red, "The value is not a number or out of the range. Try to enter it again:");
            }
            return iLine;
        }

        static int[] InitArray()
        {
            Console.Write("Enter the size of array: ");
            int[] userArray = new int[ReadAndValidate(false)]; // 'false' arg. means Zero is not allowed as the size of the array
            Console.WriteLine("\nEnter the array's elements (each number to separate by Enter):");
            for (int iCount = 0; iCount < userArray.Length; iCount++)
                userArray[iCount] = ReadAndValidate();
            return userArray;
        }

        static void PrintArray(int[] argArray)
        {
            Console.WriteLine("Array is:");
            string Sum = " ";
            for (int iCount = 0; iCount < argArray.Length; iCount++)
            {
                Sum += argArray[iCount] + "; ";
            }
            WriteColorLine(ConsoleColor.Green, Sum);            
        }

        static void WriteColorLine(ConsoleColor sColor, string sMessage)
        {
            Console.ForegroundColor = sColor;
            Console.WriteLine(sMessage);
            Console.ResetColor();
        }

        static bool IsRepeat () //Service function
        {            
            WriteColorLine(ConsoleColor.White, "\nDo you want to repeat operations? Y/N");
            string sRepeat = Console.ReadLine();
            bool bRepeat = (sRepeat == "y" || sRepeat == "Y") ? true : false;
            return bRepeat;
        }

        //******************STACK API**************
        static void StackPush(string[] Stack, string sMessage)
        {
            if (!StackIsFull(Stack))
                Stack[++top] = sMessage;
            else
                WriteColorLine(ConsoleColor.Red, "Stack is full. To add new element do Pop before next Push");
        }

        static string StackPop(string[] Stack) // Get the item and then removed it from the stack
        {            
            string sMessage;
            sMessage = Stack[top--];
            Stack[++top] = "";
            return sMessage;
        }

        static bool StackIsEmpty()
        {            
            bool isEmpty;
            isEmpty = (top < 0) ? true : false;
            return isEmpty;
        }

        static bool StackIsFull(string[] Srack)
        {         
            bool isFull;
            isFull = (top == Srack.Length - 1) ? true : false;
            return isFull;
        }

        static void StackPick()  //Get data from stack without pop
        {

        }

        static string[] StackInit()
        {            
            Console.Write("Enter the size of Stack: ");            
            string[] Stack = new string[ReadAndValidate(false)]; // 'false' arg. means Zero is not allowed as the size of the array            
            top = -1;
            return Stack;
        }

        static void StackDestroy(string[] Stack)
        {

        }

        //******************Queue API**************
        static void Enqueue(string[] Stack, string sMessage)  //Put element in queue
        {

        }

        static string Dequeue(string[] Stack) //Get element from queue (through out parameter, true if element got from queue, false otherwise)
        {
            string sMessage="";

            return sMessage;
        }

        static void QueueIsEmpty() //Return true if buffer is empty
        {

        }

        static void QueueIsFull() //Return true if buffer is full
        {

        }

    }
}
