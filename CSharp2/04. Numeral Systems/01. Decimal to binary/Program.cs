using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            long decInput = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(decInput));
        }

        static string DecimalToBinary(long decNumber)
        {
            string binary = "";

            do
            {
                long bit = decNumber % 2;
                binary = bit + binary;
                decNumber /= 2;
            } while (decNumber != 0);

            return binary;
        }
    }
}
