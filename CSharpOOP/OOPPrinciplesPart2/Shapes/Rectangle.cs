namespace Shapes
{
    using System;

    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value < 1 || value > double.MaxValue)
                {
                    throw new ArgumentException("Width argument exception");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value < 1 || value > double.MaxValue)
                {
                    throw new ArgumentException("Height argument exception");
                }
                this.height = value;
            }
        }

        public override double CalculateSurface()
        {
            return this.width * this.height;
        }
    }
}
