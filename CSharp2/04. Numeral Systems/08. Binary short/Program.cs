using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(short.Parse(Console.ReadLine()),2).PadLeft(16,'0'));
        }
    }
}
 */

namespace _08.Binary_short
{
    class Program
    {
        static void Main(string[] args)
        {
            long decInput = long.Parse(Console.ReadLine());
            string binaryStr = DecimalToBinary(decInput);
            if (decInput >= 0)
            {
                binaryStr = AddZeroes(binaryStr);
                Console.WriteLine(binaryStr);
            }
            else
            {
                int binary = int.Parse(DecimalToBinary(decInput));

                binary = ~binary;


                Console.WriteLine(binary);
            }
           
        }

        static string DecimalToBinary(long decNumber)
        {
            string binary = "";

            if (decNumber < 0)
            {
                decNumber *= -1;
            }

            do
            {
                long bit = decNumber % 2;
                binary = bit + binary;
                decNumber /= 2;
            } while (decNumber != 0);

            return binary;
        }

        static string AddZeroes(string binary)
        {
            string tempBinary = binary.Substring(0);
            while (tempBinary.Length < 16)
            {
                tempBinary = '0' + tempBinary;
            }

            return tempBinary;
        }
    }
}
