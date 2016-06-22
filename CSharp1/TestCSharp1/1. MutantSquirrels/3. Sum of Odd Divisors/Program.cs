using System;

namespace _3.Sum_of_Odd_Divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());
            int sumOfOddDivisors = 0;


            for (int number = startNumber; number <= stopNumber; number++)
            {
                for (int dividor = 1; dividor <= number; dividor += 2)
                {
                    if (number % dividor == 0)
                    {
                        sumOfOddDivisors += dividor;
                    }
                }
            }

            Console.WriteLine(sumOfOddDivisors);
        }
    }
}
