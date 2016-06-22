using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Number_of_Pages
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int digit = 0;

            for (int i = 1; i <= 1000000 ; i++)
            {
                for (int y = 1,  countDigits = 1; y < 100000000; y *= 10, countDigits++)
                {
                    if (i / y < 10)
                    {
                        digit += countDigits;
                        break;
                    }
                }

                if (digit == d)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            
        }
    }
}
