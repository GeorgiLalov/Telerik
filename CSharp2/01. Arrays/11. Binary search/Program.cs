using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];
            for (int index = 0; index < arrLeight; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(binarySearch(array, 0, arrLeight - 1, int.Parse(Console.ReadLine())));
        }

        static int binarySearch(int[] array, int begin, int end, int search)
        {
            if (begin > end)
            {
                return -1;
            }
            else
            {
                int halfElement = (begin + end) / 2;
                if (array[halfElement] > search)
                {
                    return binarySearch(array, begin, halfElement - 1, search);
                }
                else if (array[halfElement] < search)
                {
                    return binarySearch(array, halfElement + 1, end, search);
                }
                else
                {
                    return halfElement;
                }
            }

        }
    }
}
