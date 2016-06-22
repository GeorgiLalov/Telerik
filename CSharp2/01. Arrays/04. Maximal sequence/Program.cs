using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];
            int leightOfMaxSequence = 1;
            int leightOfCurrentSequence = 1;
            array[0] = int.Parse(Console.ReadLine());
            int previousElement = array[0];

            for (int index = 1; index < arrLeight; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
                if (array[index] == previousElement)
                {
                    leightOfCurrentSequence++;
                    if (index == (arrLeight - 1) && leightOfCurrentSequence >= leightOfMaxSequence)
                    {
                        leightOfMaxSequence = leightOfCurrentSequence;
                    }
                }
                else
                {
                    if (leightOfCurrentSequence >= leightOfMaxSequence)
                    {
                        leightOfMaxSequence = leightOfCurrentSequence;
                    }
                    leightOfCurrentSequence = 1;
                }
                previousElement = array[index];
            }

            Console.WriteLine(leightOfMaxSequence);
        }
    }
}
