using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DancingMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long sum = 0;
            double count = 0.0;
            string instructions = null;
            int previousIndex = 0;

            while ((instructions = Console.ReadLine()) != "stop")
            {
                string[] instrSplit = instructions.Split(' ');

                int times = int.Parse(instrSplit[0]);
                string direction = instrSplit[1]; 
                int step = int.Parse(instrSplit[2]);
                count += 1.0;

                if (direction.Equals("right"))
                {
                    int index;
                    int countTimes = 0;
                    for (index = previousIndex + step; countTimes < times; index += step, countTimes++)
                    {
                        while (index >= array.Length)
                        {
                            index = index - array.Length;
                        }
                        sum += array[index];
                    }

                    previousIndex = index - step;
                }
                else
                {
                    int index;
                    int countTimes = 0;
                    for (index = previousIndex - step; countTimes < times; index -= step, countTimes++)
                    {
                        while (index < 0)
                        {
                            index = array.Length + index;
                        }
                        sum += array[index];
                    }

                    previousIndex = index + step;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("0.0");
            }
            else
            {
                Console.WriteLine("{0:F1}", sum / count);
            }
        }
    }
}
