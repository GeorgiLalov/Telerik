using System;

class Sequence
{
    static void Main(string[] args)
    {
        int y;
        for (int i = 2; i < 1002; i++)
        {
            y = i;
            if ((y % 2) == 1)
                y *= -1;
            Console.WriteLine(y);
        }
    }
}