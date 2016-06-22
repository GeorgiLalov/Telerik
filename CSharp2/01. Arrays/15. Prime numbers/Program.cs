using System;

namespace _15.Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFromConsole = int.Parse(Console.ReadLine());

            byte[] isPrime = new byte[numberFromConsole + 1];
            int maxPrimeNumber = 0;

            for (int number = 2; number <= numberFromConsole; number++)
            {
                if (isPrime[number] == 0)
                {
                    maxPrimeNumber = number;

                    for (int nthNumber = number * 2; nthNumber <= numberFromConsole; nthNumber += number)
                    {
                        isPrime[nthNumber] = 1;
                    }
                }
            }

            Console.WriteLine(maxPrimeNumber);
        }
    }
}
