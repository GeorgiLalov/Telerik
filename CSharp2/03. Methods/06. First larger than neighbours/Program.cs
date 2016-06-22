using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[arrLeight];

            for (int index = 0; index < arrLeight; index++)
            {
                array[index] = int.Parse(input[index]);
            }

            Console.WriteLine(getFirstBiggerIndex(array, arrLeight));
        }

        static int getFirstBiggerIndex(int[] array, int arrLeight) 
        {
            for (int index = 0; index < arrLeight; index++)
            {
                if (checkNeighbours(array, index, arrLeight))
                {
                    return index;
                }
            }

            return -1;
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
