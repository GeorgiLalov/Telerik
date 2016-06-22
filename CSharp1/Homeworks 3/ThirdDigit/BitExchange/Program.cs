using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            uint a = 1;
            for(int i = 3, y = 24; i < 6; i++, y++)
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
