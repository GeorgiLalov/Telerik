using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the array leight :");
            int arrLeight = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];

            for (int index = 0; index < arrLeight; index++)
            {
                Console.WriteLine("Input array[{0}] = ", index);
                array[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Input number k : ");
            int numberK = int.Parse(Console.ReadLine());

            Array.Sort(array);
            int indexOfSearchedNum = 0;
            for (int number = numberK; number >= 0; number--)
            {
                indexOfSearchedNum = Array.BinarySearch(array, number);
                if (indexOfSearchedNum >= 0)
                {
                    break;
                }
            }

            Console.WriteLine("Searched number is in index {0}", indexOfSearchedNum);
        }
    }
}
