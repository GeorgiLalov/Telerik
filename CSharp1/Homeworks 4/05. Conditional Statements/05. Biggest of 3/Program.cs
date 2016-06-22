using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Biggest_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double max = 0;

            if (a > b)
                max = a;
            else
                max = b;

            if (c > max)
                max = c;

            Console.WriteLine(max);
        }
    }
}
