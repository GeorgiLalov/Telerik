using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int searchedNum = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];
            int countRepeats = 0;

            for (int index = 0; index < arrLeight; index++)
            {
                array[index] = int.Parse(input[index]);
            }

            countRepeats = CountRepeatingNumber(array, arrLeight, searchedNum);

            Console.WriteLine(countRepeats);
        }

        static int CountRepeatingNumber(int[] array, int arrLeight, int searchedNumber)
        {
            int countRepeats = 0;

            for (int index = 0; index < arrLeight; index++)
            {
                if (array[index] == searchedNumber)
                {
                    countRepeats++;
                }
            }

            return countRepeats;
        }
    }
}
