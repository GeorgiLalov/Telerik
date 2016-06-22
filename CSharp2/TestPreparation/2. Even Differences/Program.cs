using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Even_Differences
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int index = 1;
            long sum = 0;

            while (index < array.Length)
            {
                long abDifferences = array[index] - array[index - 1];
                if (abDifferences < 0)
                {
                    abDifferences *= -1;
                }
                if ((abDifferences % 2) == 0)
                {
                    index += 2;
                    sum += abDifferences;
                }

                else
                {
                    index += 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}