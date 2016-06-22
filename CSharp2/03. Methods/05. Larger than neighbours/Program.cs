using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_than_neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[arrLeight];
            int countBiggerNumbers = 0;

            for (int index = 0; index < arrLeight; index++)
            {
                array[index] = int.Parse(input[index]);
            }

            for (int index = 0; index < arrLeight; index++)
            {
                if (checkNeighbours(array, index, arrLeight))
                {
                    countBiggerNumbers++;
                }
            }

            Console.WriteLine(countBiggerNumbers);
        }

        static bool checkNeighbours(int[] array, int index, int arrLeight)
        {
            if (index <= 0 || index >= arrLeight - 1)
            {
                return false;
            }

            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
