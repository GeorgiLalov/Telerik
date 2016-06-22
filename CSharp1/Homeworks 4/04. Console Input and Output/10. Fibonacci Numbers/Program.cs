using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long previous = 1;
            long preprevious = 0;

            Console.Write(preprevious);
            if(n != 1)
            {
                for(int i = 1; i < n; i++)
                {
                    Console.Write(", {0}", previous);
                    previous += preprevious;
                    preprevious = previous - preprevious;
                }
            }
            Console.WriteLine();
        }
    }
}
