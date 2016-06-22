using System;
class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (x < 2)
            Console.WriteLine("false");
        else
        {
            for (int i = 2; i <= (x / 2); i++)
            {
                if ((x % i) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
