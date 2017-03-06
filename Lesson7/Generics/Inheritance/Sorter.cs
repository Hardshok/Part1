using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public abstract class Sorter<T> : ISorter<T>    
    {
        protected T[] myArray;
        protected Comparable[] arrayOfObjects;
        public abstract void SortAscending();
        public abstract void SortDescending();

        public Sorter(T[] array)
        {
            myArray = array;
            InitArrayOfObjects();
        }

        public Comparable[] ArrayOfObjects
        {
            get
            {
                return this.arrayOfObjects;
            }
            set
            {
                this.arrayOfObjects = value;
            }
        }

        protected void InitArrayOfObjects()
        {
            arrayOfObjects = new Comparable[myArray.Length];
            for (int iCount = 0; iCount < arrayOfObjects.Length; iCount++) {
                Comparable temp = new Comparable();
                temp.ComparableItem = Convert.ToInt32(myArray[iCount]);
                ArrayOfObjects[iCount] = temp;
            }
        }
            
        public void Swap(int index1, int index2)
        {
            Comparable temp = arrayOfObjects[index1];
            arrayOfObjects[index1] = arrayOfObjects[index2];
            arrayOfObjects[index2] = temp;
        }

        public void Print()
        {
            Console.Write("Actual Buffer is: ");
            string Sum = "";
            for (int iCount = 0; iCount < arrayOfObjects.Length; iCount++)
                Sum += ArrayOfObjects[iCount].ComparableItem + "; ";
            MyServiceFunctions.WriteColorLine(ConsoleColor.Green, "[ " + Sum + "]");
        }
    }
}
