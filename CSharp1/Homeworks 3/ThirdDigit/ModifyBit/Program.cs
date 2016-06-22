using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt64 number = UInt64.Parse(Console.ReadLine());
            int shift = int.Parse(Console.ReadLine());
            int boo = int.Parse(Console.ReadLine());
            UInt64 bin = 1;
            if (boo == 1)
                number = ((bin << shift) | number);
            else
                number = (~(bin << shift)) & number;
            Console.WriteLine(number);
        }
    }
}
