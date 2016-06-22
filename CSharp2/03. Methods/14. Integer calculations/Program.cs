using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long[] inputInt = LongParseArr(input, input.Length);
            long min = Minimum(inputInt[0], inputInt[1], inputInt[2], inputInt[3], inputInt[4]);
            long max = Maximum(inputInt[0], inputInt[1], inputInt[2], inputInt[3], inputInt[4]);
            double avg = Average(inputInt[0], inputInt[1], inputInt[2], inputInt[3], inputInt[4]);
            long sum = Sum(inputInt[0], inputInt[1], inputInt[2], inputInt[3], inputInt[4]);
            long product = Product(inputInt[0], inputInt[1], inputInt[2], inputInt[3], inputInt[4]);

            Console.WriteLine("{0}\n{1}\n{2:F2}\n{3}\n{4}", min, max, avg, sum, product);

        }

        static long[] LongParseArr(string[] stringArr, int length)
        {
            long[] intArr = new long[length];

            for (int index = 0; index < length; index++)
            {
                intArr[index] = long.Parse(stringArr[index]);
            }

            return intArr;
        }

        static long Minimum(params long[] numbers)
        {
            long minimum = 1000;

            foreach (long number in numbers)
            {
                if (number < minimum)
                {
                    minimum = number;
                }
            }

            return minimum;
        }

        static long Maximum(params long[] numbers)
        {
            long maximum = -1000;

            foreach (long number in numbers)
            {
                if (number > maximum)
                {
                    maximum = number;
                }
            }

            return maximum;
        }

        static long Sum(params long[] numbers)
        {
            long sum = 0;

            foreach (long number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        static double Average(params long[] numbers)
        {
            double avg = Sum(numbers) / 5.0;

            return avg;
        }

        static long Product(params long[] numbers)
        {
            long product = 1;

            foreach (long number in numbers)
            {
                product *= number;
            }

            return product;
        }
    }
}
