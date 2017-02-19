using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{    
    static class Program
    {
        /* 'head': start place in array to read
         * 'tail': place to which write new data */
        static int top, head, tail, count;
        
        static void Main()
        {            
            Console.Title= "SORT ARRAY METHODS, STACK AMD QUEUE";
            Console.SetWindowSize(80,45);

            bool bMainMenu = true;
            do { // user can back to the main manu
                Console.Clear();
                WriteColorLine(ConsoleColor.Yellow, "Modes:\n 1 = Sort Array: Two Methods\n 2 = Stack API with array\n 3 = Queue API with array\n 4 = EXIT");
                Console.Write("Please enter your selection: ");
                switch (ReadAndValidate(false)) {                    
                    case 1:
                        #region **** TWO SORTONG METHODS FOR ARRAY ****
                        Console.Clear();
                        WriteColorLine(ConsoleColor.Blue, "*** Sort Array: Two Methods***\n ");
                        int[] userArray = InitArray();
                        bool bRepeat = true;
                        do {    // user can select sorting method again
                            WriteColorLine(ConsoleColor.Yellow, "\nSort method:\n 1 = Bubble sorting by Ascending\n 2 = Bubble sorting by Descending");
                            WriteColorLine(ConsoleColor.Yellow, " 3 = Insertion Sort by Ascending\n 4 = Insertion Sort by Descending\n 5 = Back to Main menu");
                            Console.Write("Please enter your selection: ");                           
                            switch (ReadAndValidate(false))
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
                                    bRepeat = false;
                                    break;
                                default:
                                    WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, 4, or 5");
                                    break;
                            }                            
                        } while (bRepeat);
                        break;
                    #endregion
                    case 2:
                        #region **** IMPLEMENT STACK ****
                        Console.Clear();
                        WriteColorLine(ConsoleColor.Blue, "*** Implement Stack ***\n");
                        string[] userStack = InitStack();
                        bool bAction = true;
                        do { //user can repeat operations with Stack
                            WriteColorLine(ConsoleColor.Yellow, "\n 1 = Push Stack\n 2 = Pop Stack\n 3 = Pick\n 4 = State of Stack (IsEmpty, IsFull)\n 5 = Back to Main menu");
                            Console.Write("Select operation for Stack: ");
                            switch (ReadAndValidate(false))
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
                                case 4:
                                    Console.WriteLine("\nStack state are:");
                                    if (StackIsEmpty())
                                        WriteColorLine(ConsoleColor.White, " - Stack is empty");
                                    else
                                        WriteColorLine(ConsoleColor.White, " - Stack is not empty");
                                    if (StackIsFull(userStack))
                                        WriteColorLine(ConsoleColor.White, " - Stack is full");
                                    else
                                        WriteColorLine(ConsoleColor.White, " - Stack is not full");
                                    break;
                                case 5:
                                    bAction = false;
                                    break;
                                default:
                                    WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, 4 or 5");
                                    break;
                            }                            
                        } while (bAction);
                        break;
                    #endregion
                    case 3:
                        #region **** IMPLEMENT CIRCULAR BUFFER QUEUE ****
                        Console.Clear();
                        WriteColorLine(ConsoleColor.Blue, "*** Implement Queue - Circular Buffer ***\n");
                        string queueItem;
                        string[] userQueue = InitBuffer();
                        bool bRepeatQueue = true;
                        do {  //user can repeat operations with Queue
                            WriteColorLine(ConsoleColor.Yellow, "\n 1 = Enqueue\n 2 = Dequeue\n 3 = State of Buffer (IsEmpty, IsFull)");
                            WriteColorLine(ConsoleColor.Yellow, " 4 = Print Buffer\n 5 = Back to Main menu");
                            Console.Write("Select operation for Buffer: ");                            
                            switch (ReadAndValidate(false))
                            {
                                case 1:  // Enqueue                                
                                    Console.Write("\nEnter the string you want to write in queue: ");
                                    Enqueue(userQueue, Console.ReadLine());
                                    PrintBuffer(userQueue);
                                    break;
                                case 2:  // Dequeue                                                                                                           
                                    if (Dequeue(userQueue, out queueItem)) {                                        
                                        Console.Write("\nThe element taken from queue is: ");
                                        WriteColorLine(ConsoleColor.Green, queueItem);
                                        PrintBuffer(userQueue);
                                    }
                                    break;
                                case 3:  // Buffer's state (IsEmpty, IsFull)                                    
                                    Console.WriteLine("\nBuffer state are:");
                                    if (QueueIsEmpty())
                                        WriteColorLine(ConsoleColor.White, " - Queue is empty");
                                    else
                                        WriteColorLine(ConsoleColor.White, " - Queue is not empty");
                                    if (QueueIsFull(userQueue))
                                        WriteColorLine(ConsoleColor.White, " - Queue is full");
                                    else
                                        WriteColorLine(ConsoleColor.White, " - Queue is not full");
                                    break;
                                case 4:
                                    PrintBuffer(userQueue);
                                    break;
                                case 5:
                                    bRepeatQueue = false;
                                    break;
                                default:
                                    WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, 4, or 5");
                                    break;
                            }
                        } while (bRepeatQueue);
                        break;
                    #endregion
                    case 4:
                        bMainMenu = false;
                        break;
                    default:
                        WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, or 4");
                        break;
                }                
            } while (bMainMenu);
            WriteColorLine(ConsoleColor.White, "\nPress any key to exit...");
            Console.ReadKey();
        }

        #region ****** ARRAY SORTING ******

        static void BubbleSortAscending(int[] argArray) 
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

        static void BubbleSortDescending(int[] argArray) 
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

        static int[] InitArray()
        {
            Console.Write("Enter the SIZE of array: ");
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
        #endregion

        #region ****** STACK API ******
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
            Console.Write("Enter the SIZE of Stack: ");
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
        #endregion

        #region ****** QUEUE API ******
        static string[] InitBuffer()
        {
            Console.Write("Enter the SIZE of buffer: ");
            string[] Buffer = new string[ReadAndValidate(false)]; // 'false' arg. means Zero is not allowed as the size of the array                        
            head = tail = count = 0;
            Console.WriteLine(" - Empty buffer is created with size {0}", Buffer.Length);
            return Buffer;
        }

        static void Enqueue(string[] buffer, string element)  //Write element in queue
        {
            if (!QueueIsFull(buffer)) {                
                buffer[tail++] = element;
                if (tail == buffer.Length)
                    tail = 0;
                count++;
            }
            else
                WriteColorLine(ConsoleColor.Red, "\nQueue is FULL. To write new element do 'Dequeue' first");            
        }        

        //Remove from queue (through out parameter, true if element got from queue, false otherwise)
        static bool Dequeue(string[] buffer, out string queueItem)
        {
            queueItem = "";
            bool bResult = false;
            if (!QueueIsEmpty())
            {
                queueItem = buffer[head++];
                if (head == buffer.Length)
                    head = 0;
                count--;
                bResult = true;
            }
            else
                WriteColorLine(ConsoleColor.Red, "\nQueue is EMPTY. Write new element first ('Enqueue')");
            return bResult;
        }

        static bool QueueIsEmpty() //Return true if buffer is empty
        {
            bool IsEmpty;
            IsEmpty = (count == 0) ? true : false;
            return IsEmpty;
        }

        static bool QueueIsFull(string[] buffer) //Return true if buffer is full
        {
            bool IsFull;
            IsFull = (count == buffer.Length) ? true : false;
            return IsFull;
        }

        static void PrintBuffer(string[] buffer) 
        {
            Console.WriteLine("\nNow cycle buffer is:");
            for (int iCount = 0; iCount < buffer.Length; iCount++)
            {                   
                if (head == iCount)
                    Console.Write("              <-- head");
                if (tail == iCount)
                    Console.Write("              <-- tail");
                WriteColorLine(ConsoleColor.Green, "\r  Item " + iCount + ": " + buffer[iCount]);                
            }
        }
        #endregion

        #region ****** SERVICE METHODS ******    

        static void WriteColorLine(ConsoleColor sColor, string sMessage)
        {
            Console.ForegroundColor = sColor;
            Console.WriteLine(sMessage);
            Console.ResetColor();
        }
        static bool IsRepeat(string message)
        {
            WriteColorLine(ConsoleColor.White, "\n" + message + " Y/N");
            string sRepeat = Console.ReadLine();
            bool bRepeat = (sRepeat == "y" || sRepeat == "Y") ? true : false;
            return bRepeat;
        }
        
        /// <summary>
        /// Read console line and convert it to Int32. User have to enter while it will be not number. By default '0' is allowed. 
        /// </summary>
        /// <param name="isZeroAllowed"></param>
        /// <returns></returns>
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
        #endregion
    }
}
