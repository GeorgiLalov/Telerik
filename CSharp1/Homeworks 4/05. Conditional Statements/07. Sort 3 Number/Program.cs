﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort_3_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(a >= b && b >= c)
                Console.WriteLine("{0} {1} {2}", a, b, c);
            else if (b >= a && a >= c)
                Console.WriteLine("{0} {1} {2}", b, a, c);
            else if (b >= c && c >= a)
                Console.WriteLine("{0} {1} {2}", b, c, a);
            else if (a >= c && c >= b)
                Console.WriteLine("{0} {1} {2}", a, c, b);
            else if (c >= b && b >= a)
                Console.WriteLine("{0} {1} {2}", c, b, a);
            else if (c >= a && a >= b)
                Console.WriteLine("{0} {1} {2}", c, a, b);
        }
    }
}
