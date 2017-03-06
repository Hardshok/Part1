using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Comparable : IComparable
    {
        protected int item;

        public int ComparableItem 
        {
            get 
            {
                return this.item;
            }
            set 
            {
                this.item = value;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Comparable otherComparable = obj as Comparable;
            if (otherComparable != null)
                return this.item.CompareTo(otherComparable.item);
            else
                throw new ArgumentException("Object is not comparable item");
        }
    }
}
