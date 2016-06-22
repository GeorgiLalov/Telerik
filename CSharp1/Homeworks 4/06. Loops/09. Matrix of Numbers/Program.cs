using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int y = i; y <= n + i; y++)
                {
                    Console.Write("{0} ", y);
                }
                Console.WriteLine();
            }
        }
    }
}
