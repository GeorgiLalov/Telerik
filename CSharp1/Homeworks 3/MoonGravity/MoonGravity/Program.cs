using System;

class MoonGrvity
{
    static void Main(string[] args)
    {
        double w = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F3}", (w * 17) / 100.0 );
    }
}

