using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraysLeight = int.Parse(Console.ReadLine());
            int[] arrOne = new int[arraysLeight];
            int[] arrTwo = new int[arraysLeight];
            bool isEqual = true;

            for (int index = 0; index < arraysLeight; index++)
            {
                arrOne[index] = int.Parse(Console.ReadLine());
            }
            for (int index = 0; index < arraysLeight; index++)
            {
                arrTwo[index] = int.Parse(Console.ReadLine());
            }

            for (int index = 0; index < arraysLeight; index++)
            {
                if (arrOne[index] != arrTwo[index])
                {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

        }
    }
}
