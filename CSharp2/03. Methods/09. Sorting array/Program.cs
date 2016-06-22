using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[arrLength];

            for (int index = 0; index < arrLength; index++)
            {
                array[index] = int.Parse(input[index]);
            }

            SortArray(array, arrLength);
            PrintArray(array);
        }

        static void SortArray(int[] array, int arrLength)
        {
            for (int endIndex = arrLength - 1; endIndex > 0; endIndex--)
            {
                int changeIndex = GetMaxElementByIndex(array, endIndex);
                int temp = array[changeIndex];
                array[changeIndex] = array[endIndex];
                array[endIndex] = temp;
            }
        }

        static int GetMaxElementByIndex(int[] array, int endIndex)
        {
            int maxElement = int.MinValue;
            int maxIndex = 0;

            for (int index = 0; index <= endIndex; index++)
            {
                if (array[index] > maxElement)
                {
                    maxElement = array[index];
                    maxIndex = index;
                }
            }

            return maxIndex;
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write("{0} ", element);
            }

            Console.WriteLine();
        }
    }
}
