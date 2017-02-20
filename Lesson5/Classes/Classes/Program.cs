using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    static class MyProgram
    {
        static void Main()
        {
            Console.Title = "SORT ARRAY METHODS, STACK AMD QUEUE";
            Console.SetWindowSize(80, 45);            
            bool bMainMenu = true;
            do { // user can back to the main manu
                Console.Clear();
                MyServiceFunctions.WriteColorLine(ConsoleColor.Yellow, "Modes:\n 1 = Sort Array: Two Methods\n 2 = Stack API with array\n 3 = Queue API with array\n 4 = EXIT");
                Console.Write("Please enter your selection: ");
                switch (MyServiceFunctions.ReadAndValidate(false)) {
                    case 1:                        
                        #region **** TWO SORTONG METHODS FOR ARRAY ****
                        Console.Clear();
                        MyServiceFunctions.WriteColorLine(ConsoleColor.Blue, "*** Sort Array: Two Methods***\n ");
                        int[] userArray = InitUserArray();
                        BubbleSorter bublesorter = new BubbleSorter(userArray);
                        InsertionSorter insertionSorter = new InsertionSorter(userArray);
                        bool bRepeat = true;
                        do {    // user can select sorting method again
                            MyServiceFunctions.WriteColorLine(ConsoleColor.Yellow, "\nSort method:\n 1 = Bubble sorting by Ascending\n 2 = Bubble sorting by Descending");
                            MyServiceFunctions.WriteColorLine(ConsoleColor.Yellow, " 3 = Insertion Sort by Ascending\n 4 = Insertion Sort by Descending\n 5 = Back to Main menu");
                            Console.Write("Please enter your selection: ");
                            switch (MyServiceFunctions.ReadAndValidate(false)) {
                                case 1:
                                    MyServiceFunctions.WriteColorLine(ConsoleColor.Blue, "\n***Bubble sorting by Ascending***");                                    
                                    bublesorter.SortAscending();                                    
                                    bublesorter.PrintArray();
                                    break;
                                case 2:
                                    MyServiceFunctions.WriteColorLine(ConsoleColor.Blue, "\n***Bubble sorting by Descending***");
                                    bublesorter.SortDescending();
                                    bublesorter.PrintArray();
                                    break;
                                case 3:
                                    MyServiceFunctions.WriteColorLine(ConsoleColor.Blue, "\n***Insertion sort by Ascending***");
                                    insertionSorter.SortAscending();
                                    insertionSorter.PrintArray();
                                    break;
                                case 4:
                                    MyServiceFunctions.WriteColorLine(ConsoleColor.Blue, "\n***Insertion sort by Descending***");
                                    insertionSorter.SortDescending();
                                    insertionSorter.PrintArray();
                                    break;
                                case 5:
                                    bRepeat = false;
                                    break;
                                default:
                                    MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, 4, or 5");
                                    break;
                            }
                        } while (bRepeat);
                        break;
                        #endregion
                    case 2:
                        #region **** IMPLEMENT STACK ****
                        Console.Clear();
                        MyServiceFunctions.WriteColorLine(ConsoleColor.Blue, "*** Implement Stack ***\n");                        
                        Console.Write("Enter the SIZE of Stack: ");
                        MyStack stack = new MyStack(MyServiceFunctions.ReadAndValidate(false)); // 'false' arg. means Zero is not allowed as the size of the array
                        bool bAction = true;
                        do { //user can repeat operations with Stack
                            MyServiceFunctions.WriteColorLine(ConsoleColor.Yellow, "\n 1 = Push\n 2 = Pop\n 3 = Peek\n 4 = State of Stack (IsEmpty, IsFull)\n 5 = Back to Main Menu");
                            Console.Write("Select operation for Stack: ");
                            switch (MyServiceFunctions.ReadAndValidate(false)) {
                                case 1:                               
                                    Console.Write("\nEnter string to PUSH: ");
                                    stack.Push(Console.ReadLine());
                                    stack.Print();
                                    break;
                                case 2:
                                    if (!stack.IsEmpty())
                                        Console.Write("\nPOP gets the element: ");
                                    MyServiceFunctions.WriteColorLine(ConsoleColor.Green, stack.Pop());
                                    stack.Print();
                                    break;
                                case 3:
                                    if (!stack.IsEmpty())
                                        Console.Write("\nPEEK gets the top element in Stack: ");
                                    MyServiceFunctions.WriteColorLine(ConsoleColor.Green, stack.Peek());
                                    stack.Print();
                                    break;
                                case 4:
                                    Console.WriteLine("\nStack state are:");
                                    if (stack.IsEmpty())
                                        MyServiceFunctions.WriteColorLine(ConsoleColor.White, " - Stack is empty");
                                    else
                                        MyServiceFunctions.WriteColorLine(ConsoleColor.White, " - Stack is not empty");
                                    if (stack.IsFull())
                                        MyServiceFunctions.WriteColorLine(ConsoleColor.White, " - Stack is full");
                                    else
                                        MyServiceFunctions.WriteColorLine(ConsoleColor.White, " - Stack is not full");
                                    break;
                                case 5:
                                    bAction = false;
                                    break;
                                default:
                                    MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, 4 or 5");
                                    break;
                            }
                        } while (bAction);
                        break;
                        #endregion
                    case 3:
                        #region **** IMPLEMENT CIRCULAR BUFFER QUEUE ****
                        Console.Clear();
                        MyServiceFunctions.WriteColorLine(ConsoleColor.Blue, "*** Implement Queue - Circular Buffer ***\n");
                        string queueItem;
                        Console.Write("Enter the SIZE of buffer: ");                        
                        MyQueue userQueue = new MyQueue(MyServiceFunctions.ReadAndValidate(false));                                                
                        bool bRepeatQueue = true;
                        do {  //user can repeat operations with Queue
                            MyServiceFunctions.WriteColorLine(ConsoleColor.Yellow, "\n 1 = Enqueue\n 2 = Dequeue\n 3 = State of Buffer (IsEmpty, IsFull)");
                            MyServiceFunctions.WriteColorLine(ConsoleColor.Yellow, " 4 = Print Buffer\n 5 = Back to Main menu");
                            Console.Write("Select operation for Buffer: ");
                            switch (MyServiceFunctions.ReadAndValidate(false)) {
                                case 1:  // Enqueue                                
                                    Console.Write("\nEnter the string you want to write in queue: ");
                                    userQueue.Enqueue(Console.ReadLine());
                                    userQueue.Print();
                                    break;
                                case 2:  // Dequeue                                                                                                           
                                    if (userQueue.Dequeue(out queueItem))
                                    {
                                        Console.Write("\nThe element takken from queue is: ");
                                        MyServiceFunctions.WriteColorLine(ConsoleColor.Green, queueItem);
                                        userQueue.Print();
                                    }
                                    break;
                                case 3:  // Buffer's state (IsEmpty, IsFull)                                    
                                    Console.WriteLine("\nBuffer state are:");
                                    if (userQueue.IsEmpty())
                                        MyServiceFunctions.WriteColorLine(ConsoleColor.White, " - Queue is empty");
                                    else
                                        MyServiceFunctions.WriteColorLine(ConsoleColor.White, " - Queue is not empty");
                                    if (userQueue.IsFull())
                                        MyServiceFunctions.WriteColorLine(ConsoleColor.White, " - Queue is full");
                                    else
                                        MyServiceFunctions.WriteColorLine(ConsoleColor.White, " - Queue is not full");
                                    break;
                                case 4:
                                    userQueue.Print();
                                    break;
                                case 5:
                                    bRepeatQueue = false;
                                    break;
                                default:
                                    MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, 4, or 5");
                                    break;
                            }
                        } while (bRepeatQueue);
                        break;
                        #endregion
                    case 4:
                        bMainMenu = false;
                        break;
                    default:
                        MyServiceFunctions.WriteColorLine(ConsoleColor.Red, "Invalid selection. Please select 1, 2, 3, or 4");
                        break;
                }
            } while (bMainMenu);
            MyServiceFunctions.WriteColorLine(ConsoleColor.White, "\nPress any key to exit...");
            Console.ReadKey();
        }

        // ****** ARRAY SORTING ******
        static int[] InitUserArray()
        {
            Console.Write("Enter the SIZE of array: ");
            int[] userArray = new int[MyServiceFunctions.ReadAndValidate(false)]; // 'false' arg. means Zero is not allowed as the size of the array
            Console.WriteLine("\nEnter the array's elements (each number to separate by Enter):");
            for (int iCount = 0; iCount < userArray.Length; iCount++)
                userArray[iCount] = MyServiceFunctions.ReadAndValidate();
            return userArray;
        }        
    }
}
