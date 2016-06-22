using System;
using System.Numerics;

namespace _08.Catalan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n2 = 2 * n;
            BigInteger ans = 1;

            for (int k = 1; k <= n2; k++)
            {
                ans *= k;
            }
            for (int i = 1; i <= n + 1; i++)
            {
                ans /= i;
            }
            for (int i = 1; i <= n; i++)
            {
                ans /= i;
            }

            Console.WriteLine(ans);
        }
    }
}
