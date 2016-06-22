using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Penguin_Airlines
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            LinkedList<int>[] arrayList = new LinkedList<int>[n];

            for (int listIndex = 0; listIndex < n; listIndex++)
            {
                string[] input = Console.ReadLine().Split(' ');

                arrayList[listIndex] = new LinkedList<int>();

                if (input[0].Equals("None"))
                {
                    arrayList[listIndex].AddLast(-1);
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        arrayList[listIndex].AddLast(int.Parse(input[i]));
                    }
                }
            }

            StringBuilder[] output = new StringBuilder[n];
            string line;
            int index = 0;
            while ((line = Console.ReadLine()) != "Have a break")
            {
                output[index] = new StringBuilder();
                int[] flights = line.Split(' ').Select(int.Parse).ToArray();
                int beginFlight = flights[0];
                int endFlight = flights[1];

                foreach (int number in arrayList[beginFlight])
                {
                    if (number == -1)
                    {
                        output[index].Append("No flights available.");
                        break;
                    }
                    else if (number == endFlight)
                    {
                        output[index].Append("There is a direct flight.");
                        break;
                    }
                    else
                    {
                        foreach (int insideNum in arrayList[number])
                        {
                            if (insideNum == endFlight)
                            {
                                output[index].Append("There are flights, unfortunately they are not direct, grandma :(");
                                break;
                            }
                        }
                    }
                }

                if (output[index].Length == 0)
                {
                    output[index].Append("No flights available.");
                }

                index++;
            }

            foreach (StringBuilder str in output)
            {
                Console.WriteLine(str);
            }
        }
    }
}
