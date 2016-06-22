using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = GeorgeToDecimal(Console.ReadLine());
            string operation = Console.ReadLine();
            BigInteger secondNum = GeorgeToDecimal(Console.ReadLine());

            if (operation.Equals("+"))
            {
                Console.WriteLine(DecimalToGeorge(firstNum + secondNum));
            }
            else
            {
                Console.WriteLine(DecimalToGeorge(firstNum - secondNum));
            }

        }

        static BigInteger GeorgeToDecimal(string george)
        {
            StringBuilder str = new StringBuilder();
            BigInteger dec = 0;
            BigInteger baseD = 10;
            int count = 0;
            string[] georgeChars =
            {
                "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan"
            };

            foreach (char letter in george)
            {
                str.Append(letter);
                count++;
                if (count % 3 == 0)
                {
                    dec = (BigInteger)Array.IndexOf(georgeChars, str.ToString()) + dec * baseD;
                    count = 0;
                    str = new StringBuilder();
                }
            }

            return dec;
        }

        static string DecimalToGeorge(BigInteger dec)
        {
            string george = "";
            BigInteger baseD = 10;
            string[] georgeChars =
            {
                "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan"
            };

            do
            {
                george = georgeChars[(int)(dec % baseD)] + george;
                dec /= baseD;
            } while (dec != 0);

            return george;
        }
    }
}
