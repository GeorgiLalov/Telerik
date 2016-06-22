using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Penguin_Airlines2._0
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

                output[index].Append(Search(arrayList, beginFlight, endFlight, n));

                index++;
            }

            foreach (StringBuilder str in output)
            {
                if (str != null)
                {
                    Console.WriteLine(str);
                }
                
            }
        }

        static string Search(LinkedList<int>[] arrayList, int searchFrom, int searchTo, int n)
        {
            string answer = "No flights available.";
            Queue<int> queue = new Queue<int>();
            bool[] isVisited = new bool[n];
            int count = 0;

            queue.Enqueue(searchFrom);
            int number;

            while (queue.Count != 0)
            {
                number = queue.Dequeue();
                foreach (int num in arrayList[number])
                {
                    if (num == -1)
                    {
                        answer = "No flights available.";
                        queue.Clear();
                        break;
                    }

                    if (isVisited[num])
                    {
                        continue;
                    }
                    else
                    {
                        isVisited[num] = true;
                        queue.Enqueue(num);
                    }

                    if (num == searchTo)
                    {
                        if (count == 0)
                        {
                            answer = "There is a direct flight.";
                        }
                        else
                        {
                            answer = "There are flights, unfortunately they are not direct, grandma :(";
                        }
                        
                        queue.Clear();
                        break;
                    }
                }

                count++;
                
            }

            return answer;
        }
    }
}
