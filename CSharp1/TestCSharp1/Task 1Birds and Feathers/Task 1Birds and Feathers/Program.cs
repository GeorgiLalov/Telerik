using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1Birds_and_Feathers
{
    class Program
    {
        static void Main(string[] args)
        {
            long b = long.Parse(Console.ReadLine());
            long f = long.Parse(Console.ReadLine());

            double result = f / (b * 1.0);
            double magic = 0;


            if(b % 2 == 0)
            {
                magic = 123123123123.0 * result;
            }
            else
            {
                magic = result / 317.0;
            }

            Console.WriteLine("{0:F4}", magic);
        }
    }
}
