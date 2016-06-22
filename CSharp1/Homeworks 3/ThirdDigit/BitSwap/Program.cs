using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            uint a = 1;
            for (int j = 0; j < count; j++, i++, y++)
            {
                uint bitA = (number & (a << i)) >> i;
                uint bitB = (number & (a << y)) >> y;
                if (bitA == 1)
                    number = ((a << y) | number);
                else
                    number = (~(a << y)) & number;
                if (bitB == 1)
                    number = ((a << i) | number);
                else
                    number = (~(a << i)) & number;
            }
            Console.WriteLine(number);
        }
    }
}
