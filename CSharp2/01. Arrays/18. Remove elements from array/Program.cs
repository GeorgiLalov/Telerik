using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Remove_elements_from_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];
            int[] subSequences = Enumerable.Repeat(1, arrLeight).ToArray();
            int subMax = int.MinValue;

            for (int number = 0; number < arrLeight; number++)
            {   
                array[number] = int.Parse(Console.ReadLine());

                for (int subCheck = 0; subCheck < number; subCheck++)
                {
                    if ((array[subCheck] <= array[number]) && (subSequences[number] < subSequences[subCheck] + 1))
                    {
                        subSequences[number] = Math.Max(subSequences[number], subSequences[subCheck] + 1);
                    }
                }

            }

            for (int subNum = 0; subNum < arrLeight; subNum++)
            {
                if (subSequences[subNum] > subMax)
                {
                    subMax = subSequences[subNum];
                }
            }

            Console.WriteLine(arrLeight - subMax);
        }
    }
}
