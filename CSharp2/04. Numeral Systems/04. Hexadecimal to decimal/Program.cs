using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hexadecimal_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(HexademicalToDecimal(input));
        }

        static long HexademicalToDecimal(string hexademical)
        {
            long decNumber = 0;
            
            foreach (char number in hexademical)
            {
                if (char.IsDigit(number))
                {
                    decNumber = (number - '0') + decNumber * 16;
                }
                else
                {
                    decNumber = ((number - 'A' ) + 10) + decNumber * 16;
                }
            }

            return decNumber;
        }
    }
}
