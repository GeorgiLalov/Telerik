using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Maximal_K_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            int numberK = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];
            int maxSumOfKElements = 0;

            for (int index = 0; index < arrLeight; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            for (int index = arrLeight - 1; index >= arrLeight - numberK; index--)
            {
                maxSumOfKElements += array[index];
            }

            Console.WriteLine(maxSumOfKElements);

        }
    }
}
