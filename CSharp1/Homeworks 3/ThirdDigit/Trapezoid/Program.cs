using System;

class CircleRectangle
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine()) -1;
        double y = double.Parse(Console.ReadLine()) -1;

        if( Math.Sqrt((x * x) + (y * y)) <= 1.5 )
            Console.Write("inside circle ");
        else
            Console.Write("outside circle ");
        if( (x <= 4 && x >= -2) && (y <= 0 && y >= -2))
            Console.WriteLine("inside rectangle");
        else
            Console.WriteLine("outside rectangle");
        
    }
}

