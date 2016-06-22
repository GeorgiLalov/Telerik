using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                a += b;
                b = a - b;
                a -= b;
            }

            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
