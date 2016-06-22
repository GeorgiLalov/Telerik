using System;
using System.Numerics;

namespace _10.Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numberLine = Console.ReadLine();
            string[] numbers = numberLine.Split(' ');
            BigInteger productOfEven = 1;
            BigInteger productOfOdd = 1;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(numbers[i - 1]);
                if (i % 2 == 0)
                    productOfEven *= num;
                else
                    productOfOdd *= num;
            }

            if( productOfEven == productOfOdd)
                Console.WriteLine("yes {0}", productOfOdd);
            else
                Console.WriteLine("no {0} {1}", productOfOdd, productOfEven);
        }
    }
}
