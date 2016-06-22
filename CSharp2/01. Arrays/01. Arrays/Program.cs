using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];

            for (int index = 0; index < arraySize; index++)
            {
                array[index] = index * 5;
            }

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
