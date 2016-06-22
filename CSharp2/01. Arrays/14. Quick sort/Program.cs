using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Quick_sort
{
    class Program
    {
        static int[] array;

        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            array = new int[arrLeight];

            for (int index = 0; index < arrLeight; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            quickSort(0, arrLeight - 1);

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }

        static void quickSort(int beginIndex, int endIndex)
        {
            int tempBeginIndex = beginIndex;
            int tempEndIndex = endIndex;
            int middleNumber = array[(beginIndex + endIndex) / 2];
            do
            {
                while (array[tempBeginIndex] < middleNumber)
                    tempBeginIndex++;
                while (array[tempEndIndex] > middleNumber)
                    tempEndIndex--;
                if (tempBeginIndex <= tempEndIndex)
                {
                    exchangePlaces(tempBeginIndex, tempEndIndex);
                    tempBeginIndex++;
                    tempEndIndex--;
                }
            } while (tempBeginIndex <= tempEndIndex);

            if (beginIndex < tempEndIndex)
                quickSort(beginIndex, tempEndIndex);

            if (tempBeginIndex < endIndex)
                quickSort(tempBeginIndex, endIndex);
        }

        static void exchangePlaces(int indexOne, int indexTwo)
        {
            int temp = array[indexOne];
            array[indexOne] = array[indexTwo];
            array[indexTwo] = temp;
        }

    }
}
