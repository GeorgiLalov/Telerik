using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double S = 1;
            int factorial = 1;

            for(int i = 1; i <= N; i++)
            {
                factorial *= i;
                S +=  ( (factorial) / (Math.Pow(x, i)) );
            }

            Console.WriteLine("{0:F5}", S);
        }
    }
}
