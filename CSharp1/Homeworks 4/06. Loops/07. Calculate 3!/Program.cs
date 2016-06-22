using System;
using System.Numerics;

namespace _07.Calculate_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger ans = 1;
            int nk = n - k;

            for (int i = k + 1; i <= n; i++)
            {
                ans *= i;
            }
            for (int i = 1; i <= nk; i++)
            {
                ans /= i;
            }

            Console.WriteLine(ans);
        }
    }
}
