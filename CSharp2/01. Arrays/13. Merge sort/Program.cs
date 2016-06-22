using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];
            int[] tempArray = new int[arrLeight];
            for (int index = 0; index < arrLeight; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            mergeSort(array, tempArray, 0, arrLeight - 1);

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }

        static void merge(int[] array, int[] tempArray, int beginIndex, int middleIndex, int endIndex)
        {
            int i, left_end, num_elements, tmp_pos;
            left_end = middleIndex - 1;
            tmp_pos = beginIndex;
            num_elements = endIndex - beginIndex + 1;
            while ((beginIndex <= left_end) && (middleIndex <= endIndex))
            {
                if (array[beginIndex] <= array[middleIndex])
                {
                    tempArray[tmp_pos] = array[beginIndex];
                    tmp_pos = tmp_pos + 1;
                    beginIndex = beginIndex + 1;
                }
                else
                {
                    tempArray[tmp_pos] = array[middleIndex];
                    tmp_pos = tmp_pos + 1;
                    middleIndex = middleIndex + 1;
                }
            }
            while (beginIndex <= left_end)
            {
                tempArray[tmp_pos] = array[beginIndex];
                beginIndex = beginIndex + 1;
                tmp_pos = tmp_pos + 1;
            }
            while (middleIndex <= endIndex)
            {
                tempArray[tmp_pos] = array[middleIndex];
                middleIndex = middleIndex + 1;
                tmp_pos = tmp_pos + 1;
            }
            for (i = 0; i < num_elements; i++)
            {
                array[endIndex] = tempArray[endIndex];
                endIndex = endIndex - 1;
            }
        }

        static void mergeSort(int[] array, int[] tempArray, int beginIndex, int endIndex)
        {
            int middleIndex = 0;
            if (endIndex > beginIndex)
            {
                middleIndex = (endIndex + beginIndex) / 2;
                mergeSort(array, tempArray, beginIndex, middleIndex);
                mergeSort(array, tempArray, middleIndex + 1, endIndex);
                merge(array, tempArray, beginIndex, middleIndex + 1, endIndex);
            }
        }   
        
    }
}
