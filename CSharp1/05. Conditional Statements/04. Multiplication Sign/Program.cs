using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double d = a * b * c;

            if(d == 0)
                Console.WriteLine(0);
            else if(d > 0)
                Console.WriteLine("+");
            else
                Console.WriteLine("-");
        }
    }
}
