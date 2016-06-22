using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];
            int minIndex = 0;
            int tempElement = 0;

            for (int index = 0; index < arrLeight; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            // sort algoritm

            for (int beginIndex = 0; beginIndex < arrLeight - 1; beginIndex++)
            {
                minIndex = beginIndex;
                for (int secIndex = beginIndex + 1; secIndex < arrLeight; secIndex++)
                {
                    if (array[minIndex] > array[secIndex])
                    {
                        minIndex = secIndex;
                    }
                }
                tempElement = array[beginIndex];
                array[beginIndex] = array[minIndex];
                array[minIndex] = tempElement;
            }

            // print
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
