namespace Lib.Models
{
    using System.Collections;

    public class BitArray64 : IEnumerable
    {
        public ulong[] Array { get; set; }

        public BitArray64(ulong[] array)
        {
            this.Array = array;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Array.GetEnumerator();
        }

        public ulong this[int index]
        {
            get
            {
                return this.Array[index];
            }

            set
            {
                this.Array[index] = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            BitArray64 objArray = obj as BitArray64;
            if (objArray == null)
            {
                return false;
            }

            if (objArray.Array.Length != this.Array.Length)
            {
                return false;
            }

            for (int index = 0; index < this.Array.Length; index++)
            {
                if (this.Array[index] != objArray.Array[index])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray)
        {
            return firstArray.Equals(secondArray);
        }

        public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
        {
            return !(firstArray.Equals(secondArray));
        }

        public override int GetHashCode()
        {
            int prime = 13;
            int hash = 1;

            foreach (ulong number in this.Array)
            {
                hash = (hash * prime) + (int)number;
            }

            return hash;
        }
    }
}
