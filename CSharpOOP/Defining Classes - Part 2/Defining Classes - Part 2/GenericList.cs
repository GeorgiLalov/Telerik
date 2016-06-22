namespace Defining_Classes___Part_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Version(1, 0)]
    class GenericList<T>
        where T : struct, IComparable<T>
    {
        public T[] Array { get; set; }
        public int Capacity { get; private set; }
        public int Count { get; private set; }

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.Count = 0;
            this.Array = new T[this.Capacity];
        }

        public void Add(T element)
        {
            // if count equals capacity: new Array with double capacity
            if (this.Count == this.Capacity)
            {
                this.Capacity *= 2;
                T[] newArray = this.Array;
                this.Array = new T[this.Capacity];
                newArray.CopyTo(this.Array, 0);
            }
            
            this.Array[Count] = element;
            this.Count++;
            
        }

        public void Add(T element, int index)
        {
            this.CheckIndex(index);

            this.Add(element); // Put new element in the end of the Array

            for (int i = this.Count - 1; i > index; i--)
            {
                T temp = this.Array[i];
                this.Array[i] = this.Array[i - 1];
                this.Array[i - 1] = temp;
            }
        }

        public void Remove(int index)
        {
            this.CheckIndex(index);
            
            for (int i = index + 1; i < this.Count; i++)
            {
                this.Array[i - 1] = this.Array[i];
            }

            this.Count--;
        }

        public void Clear()
        {
            this.Count = 0;
            this.Array = new T[this.Capacity];
        }

        public int FindElement(T value)
        {
            int index = -1; // if element dont exist in the Array return -1

            for (int i = 0; i < this.Count; i++)
            {
                if (value.CompareTo(this.Array[i]) == 0) 
                {                               
                    index = i;
                    break;
                }
            }

            return index;
        }

        public T Min<D>()
            where D: struct, IComparable<D>
        {
            T minElement = default(T);

            for (int index = 0; index < this.Count; index++)
            {
                if (this.Array[index].CompareTo(minElement) < 0)
                {
                    minElement = this.Array[index];
                }
            }

            return minElement;
        }

        public T Max<D>()
            where D : struct, IComparable<D>
        {
            T maxElement = default(T);

            for (int index = 0; index < this.Count; index++)
            {
                if (this.Array[index].CompareTo(maxElement) > 0)
                {
                    maxElement = this.Array[index];
                }
            }

            return maxElement;
        }

        /* Check if index is in the range of Array */
        private void CheckIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }

        /* Indexer */
        public T this[int index]
        {
            get
            {
                this.CheckIndex(index);
                return this.Array[index];
            }

            set
            {
                this.CheckIndex(index);
                this.Array[index] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for(int index = 0; index < this.Count; index++)
            {
                builder.AppendFormat("{0},", this.Array[index]);
            }

            return builder.ToString().TrimEnd(new char[] { ',', ' ' });
        }

    }
}
