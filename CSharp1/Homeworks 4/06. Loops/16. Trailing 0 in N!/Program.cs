using System;

namespace _16.Trailing_0_in_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while (n >= 5)
            {
                n /= 5;
                count += n;
            }

            Console.WriteLine(count);
            
        }
    }
}
