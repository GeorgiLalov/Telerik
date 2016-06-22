namespace Defining_Classes___Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Display
    {
        private float? size;
        private long? numberOfColors;

        public float? Size
        {
            get { return size; }
            set
            {
                if (value > 0 || value == null)
                {
                    size = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

        public long? NumberOfColors
        {
            get { return numberOfColors; }
            set
            {
                if (value > 0 || value == null)
                {
                    numberOfColors = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

        public Display()
        {
            this.Size = null;
            this.NumberOfColors = null;
        }

        public Display(float size) : this()
        {
            this.Size = size;
        }

        public Display(long numberOfColors) : this()
        {
            this.NumberOfColors = numberOfColors;
        }

        public Display(float size, long numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        override
        public string ToString()
        {
            return $"{this.Size} {this.NumberOfColors}";
        }
    }
}
