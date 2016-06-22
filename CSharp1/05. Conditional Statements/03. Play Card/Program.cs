using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Play_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if( str == "2"  || str == "3" || str == "4" || str == "5" || str == "6" || str == "7" || str == "A"
                || str == "8" || str == "9" || str == "10" || str == "K" || str == "Q" || str == "J")
                Console.WriteLine("yes {0}", str);
            else
                Console.WriteLine("no {0}", str);

        }
    }
}
