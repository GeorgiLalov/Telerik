using System;

namespace _1.MutantSquirrels
{
    class Program
    {
        static void Main(string[] args)
        {

            long trees = long.Parse(Console.ReadLine());
            long branches = long.Parse(Console.ReadLine());
            long squirels = long.Parse(Console.ReadLine());
            long avgNumOfTails = long.Parse(Console.ReadLine());
            long tails = trees * branches * squirels * avgNumOfTails;
            double magic = 0;

            if( tails % 2 == 0)
            {
                magic = tails * 376439.0;
            }
            else
            {
                magic = tails / 7.0;
            }

            Console.WriteLine("{0:F3}", magic);
        }
    }
}
