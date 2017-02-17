using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{    
    static class Program
    {
        static int top;        

        static void Main()
        {            
            Console.Title= "SORT ARRAY METHODS, STACK AMD QUEUE";
            Console.SetWindowSize(80,45);

            WriteColorLine(ConsoleColor.Yellow, "Modes:\n 1 = Sort Array: Two Methods\n 2 = Stack API with array\n 3 = Queue API with array"); 
            Console.Write("Please enter your selection: ");
            //int iMode = MyProgram.ReadAndValidate(false);
            int iMode = ReadAndValidate(false);
            switch (iMode) 
            {
                case 1: //  TWO SORTONG METHODS FOR ARRAY
                    Console.Clear();
                    WriteColorLine(ConsoleColor.Blue, "*** Sort Array: Two Methods***\n ");
                    int[] userArray = InitArray();  
                    bool bRepeat=false;
                    do
                    {    // user can select sorting method again
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
                            default:
                                WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, or 4");
                                break;
                        }
                        bRepeat = IsRepeat();
                    } while (bRepeat);
                    break;
                case 2: //IMPLEMENT STACK                    
                    Console.Clear();
                    WriteColorLine(ConsoleColor.Blue, "*** Implement Stack ***\n");
                    string[] userStack = InitStack();
                    bool bAction = false;
                    do { //user can repeat operations with Stack
                        WriteColorLine(ConsoleColor.Yellow, "\n 1 = Push Stack\n 2 = Pop Stack\n 3 = Pick");
                        Console.Write("Select operation for stack: ");
                        int iOperation = ReadAndValidate(false);
                        switch (iOperation)
                        {
                            case 1: // Push                               
                                Console.Write("\nEnter string to PUSH: ");
                                StackPush(userStack, Console.ReadLine());
                                StackPrint(userStack);
                                break;
                            case 2: // Pop                                
                                if (!StackIsEmpty())
                                    Console.WriteLine("\nPOP gets the element:");
                                WriteColorLine(ConsoleColor.Green, StackPop(userStack));
                                StackPrint(userStack);
                                break;
                            case 3: // Peek
                                if (!StackIsEmpty())
                                    Console.WriteLine("\nPEEK gets the top ({0}) element:", top);
                                WriteColorLine(ConsoleColor.Green, StackPeek(userStack));
                                StackPrint(userStack);
                                break;
                            default:                                
                                WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, or 3");
                                break;
                        }
                        bAction = IsRepeat();
                    } while (bAction);
                    break;
                
                case 3: //IMPLEMENT CIRCULAR BUFFER QUEUE
                    Console.Clear();
                    WriteColorLine(ConsoleColor.Blue, "*** Implement Circular Buffer Queue ***\n");
                    Queue Queue = new Queue();
                    string[] userQueue = Queue.InitQueue();
                    bool bRepeatQueue = false;
                    do {  //user can repeat operations with Queue
                        WriteColorLine(ConsoleColor.Yellow, "\n 1 = Enqueue\n 2 = Dequeue\n 3 = IsEmpty\n 4 = IsFull");
                        Console.Write("Select operation for stack: ");
                        int iOperation = ReadAndValidate(false);                        
                        switch (iOperation)
                        {
                            case 1:  // Enqueue                                
                                
                                break;
                            case 2:  // Dequeue
                                break;
                            case 3:  // IsFull
                                break;
                            case 4:  // IsEmpty
                                break;
                            default:
                                WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, or 4");
                                break;
                        }
                        bRepeatQueue = IsRepeat();
                    } while (bRepeatQueue) ;

                        break;

                default:
                    WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, or 3");
                    break;
            }
           // bRepeat = IsRepeat();
            
            WriteColorLine(ConsoleColor.White, "Press any key to exit...");
            Console.ReadKey();
            } 

                
        // ************* Array Sorting ***************
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

        // ReadAndValidate():
        // Do ReadLine + validate that the entered value is: not a string; not empty, not out of the integer range; not 0 (if isZeroAllowed=True)
        public static int ReadAndValidate(bool isZeroAllowed = true)
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

        //****************** STACK API **************
        static void StackPush(string[] Stack, string sMessage)
        {
            if (!StackIsFull(Stack))
                Stack[++top] = sMessage;
            else
                WriteColorLine(ConsoleColor.Red, "\nStack is full. To add new element do 'Pop' first");
        }

        static string StackPop(string[] Stack) // Get the item and then removed it from the stack
        {            
            string sMessage="";
            if (!StackIsEmpty()) 
            {
                sMessage = Stack[top--];
                Stack[top+1] = "";
            }
            else
                WriteColorLine(ConsoleColor.Red, "\nStack is empty. To get top element do 'Push' first");
            return sMessage;
        }

        static string StackPeek(string[] Stack)  //Get top element without removing it from the Stack
        {
            string sMessage = "";
            if (!StackIsEmpty())
                sMessage = Stack[top];
            else
                WriteColorLine(ConsoleColor.Red, "\nStack is empty. To get top element do 'Push' first");
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

        static string[] InitStack()
        {
            Console.Write("Enter the size of Stack: ");
            string[] Stack = new string[ReadAndValidate(false)]; // 'false' arg. means Zero is not allowed as the size of the array            
            top = -1;
            Console.WriteLine(" New Stack is created with size {0}", Stack.Length);
            return Stack;
        }

        static void StackPrint(string[] Stack)
        {
            Console.Write("Now Stack is: ");
            string Sum = "";
            for (int iCount = 0; iCount <= top; iCount++)
            {
                Sum += Stack[iCount] + "; ";
            }
            WriteColorLine(ConsoleColor.Green, "[ " + Sum + "]");
        }   
    }
}
