using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Maximal_increasing_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];
            int leightOfMaxIncreasingSequence = 1;
            int leightOfCurrentIncreasingSequence = 1;
            array[0] = int.Parse(Console.ReadLine());
            int previousElement = array[0];

            for (int index = 1; index < arrLeight; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
                if (array[index] > previousElement)
                {
                    leightOfCurrentIncreasingSequence++;
                    if (index == (arrLeight - 1) && leightOfCurrentIncreasingSequence >= leightOfMaxIncreasingSequence)
                    {
                        leightOfMaxIncreasingSequence = leightOfCurrentIncreasingSequence;
                    }
                }
                else
                {
                    if (leightOfCurrentIncreasingSequence >= leightOfMaxIncreasingSequence)
                    {
                        leightOfMaxIncreasingSequence = leightOfCurrentIncreasingSequence;
                    }
                    leightOfCurrentIncreasingSequence = 1;
                }
                previousElement = array[index];
            }

            Console.WriteLine(leightOfMaxIncreasingSequence);
        }
    }
}
