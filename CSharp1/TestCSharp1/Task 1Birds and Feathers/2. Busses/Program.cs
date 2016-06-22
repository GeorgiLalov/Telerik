using System;

namespace _2.Busses
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int speed = 0;
            int previousSpeed = 0;
            int groupCount = 0;

            for (int i = 1; i <= count; i++)
            {
                speed = int.Parse(Console.ReadLine());
                if(i == 1)
                {
                    previousSpeed = speed;
                    groupCount++;
                }
                else
                {
                    if(speed <= previousSpeed)
                    {
                        previousSpeed = speed;
                        groupCount++;
                    }
                }

 
            }

            Console.WriteLine(groupCount);
        }
    }
}
