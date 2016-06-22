using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];
            int maximalSum = int.MinValue;
            int currentSum = 0;

            for (int index = 0; index < arrLeight; index++)
            {
                array[index] = int.Parse(Console.ReadLine());

                currentSum = Math.Max(0, currentSum + array[index]);
                maximalSum = Math.Max(maximalSum, currentSum);

                if (currentSum >= maximalSum)
                {
                    maximalSum = currentSum;
                }
            }

            Console.WriteLine(maximalSum);
        }
    }
}
