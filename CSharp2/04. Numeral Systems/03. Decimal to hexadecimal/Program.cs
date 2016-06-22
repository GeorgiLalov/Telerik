using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Decimal_to_hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHexadecimal(input));
        }

        static string DecimalToHexadecimal(long decNumber)
        {
            string hex = "";
            char[] dictionary = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A',
                                    'B','C','D','E','F',};

            do
            {
                long bit = decNumber % 16;
                hex = dictionary[bit] + hex;
                decNumber /= 16;
            } while (decNumber != 0);

            return hex;
        }
    }
}
