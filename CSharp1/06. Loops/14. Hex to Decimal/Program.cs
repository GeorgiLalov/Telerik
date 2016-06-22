using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Hex_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int hexLeight = hex.Length;
            int binaryLeight = 4 * hexLeight;
            long[] binary = new long[binaryLeight];
            long dec = 0;
            long count = 1;

            for (int i = 0; i < hexLeight; i++)
            {
                switch (hex[i])
                {
                    case '1': binary[4*i + 3] = 1; break;
                    case '2': binary[4 * i + 2] = 1; break;
                    case '3': binary[4 * i + 2] = 1;
                        binary[4 * i + 3] = 1; break;
                    case '4': binary[4 * i + 1] = 1; break;
                    case '5': binary[4 * i + 1] = 1;
                        binary[4 * i + 3] = 1; break;
                    case '6': binary[4 * i + 1] = 1;
                        binary[4 * i + 2] = 1; break;
                    case '7': binary[4 * i + 1] = 1;
                        binary[4 * i + 2] = 1;
                        binary[4 * i + 3] = 1; break;
                    case '8': binary[4 * i] = 1; break;
                    case '9': binary[4 * i] = 1;
                        binary[4 * i + 3] = 1; break;
                    case 'A': binary[4 * i] = 1;
                        binary[4 * i + 2] = 1; break;
                    case 'B': binary[4 * i] = 1;
                        binary[4 * i + 2] = 1;
                        binary[4 * i + 3] = 1; break;
                    case 'C': binary[4 * i] = 1;
                        binary[4 * i + 1] = 1; break;
                    case 'D': binary[4 * i] = 1;
                        binary[4 * i + 1] = 1;
                        binary[4 * i + 3] = 1; break;
                    case 'E': binary[4 * i] = 1;
                        binary[4 * i + 1] = 1;
                        binary[4 * i + 2] = 1; break;
                    case 'F': binary[4 * i] = 1;
                        binary[4 * i + 1] = 1;
                        binary[4 * i + 2] = 1;
                        binary[4 * i + 3] = 1; break;
                }
            }

            for (int i = binaryLeight - 1; i >= 0; i--)
            {
                if (binary[i] == 1)
                    dec += count;
                count *= 2;
            }

            Console.WriteLine(dec);
        }
    }
}
