using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());
            long[] binary = new long[100];
            int i = 0;
            int count = 0;

            do
            {
                binary[i++] = dec % 2;
                dec /= 2;
                count++;
            } while (dec != 0);

            for (int y = count - 1; y >= 0; y--)
            {
                Console.Write(binary[y]);
            }
        }
    }
}
