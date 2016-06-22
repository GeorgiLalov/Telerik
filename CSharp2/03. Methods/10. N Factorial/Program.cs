using System;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;

            for (int multiply = 2; multiply <= number; multiply++)
            {
                nFactorial *= multiply;
            }

            Console.WriteLine(nFactorial);

        }
    }
}
