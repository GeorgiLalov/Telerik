namespace Shapes
{
    using System;

    public static class ShapesTest
    {
        public static void Test()
        {
            Console.WriteLine("Test Shapes");

            Shape[] arrOfShapes =
            {
                new Square(2),
                new Rectangle(2, 4),
                new Triangle(3, 4)
            };

            foreach (Shape shape in arrOfShapes)
            {
                Console.WriteLine("{0} area = {1}", shape.GetType(), shape.CalculateSurface());
            }

            Console.WriteLine(".....................................");
        }
    }
}
