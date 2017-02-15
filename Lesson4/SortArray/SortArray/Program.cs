using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static void Main()
        {
            int[] userArray = InitArray();  
            bool bRepeat=false;
            do {                                  // user can select sorting method again
                Console.WriteLine("Sort method:\n 1=Bubble sorting by Ascending\n 2=Bubble sorting by Descending");
                Console.WriteLine(" 3=Insertion Sort by Ascending\n 4=Insertion Sort by Descending");
                Console.Write("Please enter your selection:");
                int iVariant = ReadAndValidate(false);

                switch (iVariant)
                {
                    case 1:
                        Console.WriteLine("Bubble sorting by Ascending");
                        int[] Array1 = userArray;
                        BubbleSortAscending(Array1);
                        PrintArray(Array1);
                        break;
                    case 2:
                        Console.WriteLine("Bubble sorting by Descending");
                        int[] Array2 = userArray;
                        BubbleSortDescending(Array2);
                        PrintArray(Array2);
                        break;
                    case 3:
                        Console.WriteLine("Insertion sort by Ascending");
                        int[] Array3 = userArray;
                        InsertionSortAscending(Array3);
                        PrintArray(Array3);
                        break;
                    case 4:
                        Console.WriteLine("Insertion sort by Descending");
                        int[] Array4 = userArray;
                        InsertionSortDescending(Array4);
                        PrintArray(Array4);
                        break;
                    case 5:
                        Console.WriteLine("Implement Stack");
                        break;
                    case 6:
                        Console.WriteLine("Implement Circular Buffer Queue");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please select 1, 2, 3, or 4");
                        break;
                }

                Console.WriteLine("\nDo you want to sort array again? Y/N");
                string sRepeat = Console.ReadLine();
                if (sRepeat == "y" || sRepeat == "Y")
                    bRepeat = true;
                else 
                    bRepeat = false;
            } while (bRepeat);
                

            Console.WriteLine("\nPress any key to exit...");
            
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
                    Console.WriteLine("The value is equal '0', not a number or out of the range. Enter it again:");
            }
            else
            {
                while (Int32.TryParse(Console.ReadLine(), out iLine) == false)
                    Console.WriteLine("The value is not a number or out of the range. Try to enter it again:");
            }
            return iLine;
        }

        static int[] InitArray()
        {
            Console.WriteLine("Enter the size of array:");
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
            Console.WriteLine(Sum);
        }
    }
}
