using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(input));
        }

        static long BinaryToDecimal(string binary)
        {
            long decNumber = 0;

            foreach (char bit in binary)
            {
                decNumber = (bit - '0') + decNumber * 2;
            }

            return decNumber;
        }
    }
}
