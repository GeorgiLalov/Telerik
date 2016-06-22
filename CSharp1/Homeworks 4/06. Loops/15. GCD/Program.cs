using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] numSplit = numbers.Split(' ');
            int a = Math.Abs(int.Parse(numSplit[0]));
            int b = Math.Abs(int.Parse(numSplit[1]));
            int t = 0;

            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }

            Console.WriteLine(a);
        }
    }
}
