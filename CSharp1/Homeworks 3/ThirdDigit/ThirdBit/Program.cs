using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            //int shift = 3;
            int shift = int.Parse(Console.ReadLine());
            int a = 1;
            Console.WriteLine( (number & (a << shift)) >> shift );
        }
    }
}
