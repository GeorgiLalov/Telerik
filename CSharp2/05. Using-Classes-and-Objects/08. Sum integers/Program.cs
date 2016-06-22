using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetSum(input));
        }

        static int GetSum(string text)
        {
            string[] textArray = text.Split(' ');
            int sum = 0; 

            foreach (string number in textArray)
            {
                sum += int.Parse(number);
            }

            return sum;
        }
    }
}
