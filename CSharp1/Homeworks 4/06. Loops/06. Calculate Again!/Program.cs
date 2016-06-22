using System;
using System.Numerics;


namespace _06.Calculate_Again_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger ans = 1;

            for (int i = k + 1; i <= n; i++)
            {
                ans *= i;
            }

            Console.WriteLine(ans);

        }
    }
}
