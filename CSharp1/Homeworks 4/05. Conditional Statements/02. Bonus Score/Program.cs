using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (score > 0 && score < 4)
            {
                score *= 10;
                Console.WriteLine(score);
            }
            else if (score > 3 && score < 7)
            {
                score *= 100;
                Console.WriteLine(score);

            }
            else if (score > 6 && score < 10)
            {
                score *= 1000;
                Console.WriteLine(score);

            }
            else
                Console.WriteLine("invalid score");
        }
    }
}
