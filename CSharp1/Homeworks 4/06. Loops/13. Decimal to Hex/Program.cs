using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decimal_to_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());
            long[] binary = new long[100];
            int increment = 0;
            int countBinaryLeight = 0;
            int countHexLeight = -1;
            long[] hex = new long[100];
            char[] hexToChar = new char[100];
            long number = 1;

             // from dec 20 -> 00101 in binary
            do
            {
                binary[increment++] = dec % 2;
                dec /= 2;
                countBinaryLeight++;
            } while (dec != 0);

            // 0010 1000 -> 41 in hex
            for (int i = 0; i < countBinaryLeight; i++)
            {
                if (i % 4 == 0)
                {
                    countHexLeight++;
                    number = 1;
                }

                if (binary[i] == 1)
                    hex[countHexLeight] += number;
                number *= 2;
            }

            // 41 -> 41 char
            for (int i = 0; i <= countHexLeight; i++)
            {
                switch (hex[i])
                {
                    case 0: hexToChar[i] = '0'; break;
                    case 1: hexToChar[i] = '1'; break;
                    case 2: hexToChar[i] = '2'; break;
                    case 3: hexToChar[i] = '3'; break;
                    case 4: hexToChar[i] = '4'; break;
                    case 5: hexToChar[i] = '5'; break;
                    case 6: hexToChar[i] = '6'; break;
                    case 7: hexToChar[i] = '7'; break;
                    case 8: hexToChar[i] = '8'; break;
                    case 9: hexToChar[i] = '9'; break;
                    case 10: hexToChar[i] = 'A'; break;
                    case 11: hexToChar[i] = 'B'; break;
                    case 12: hexToChar[i] = 'C'; break;
                    case 13: hexToChar[i] = 'D'; break;
                    case 14: hexToChar[i] = 'E'; break;
                    case 15: hexToChar[i] = 'F'; break;
                    
                }
            }

            for (int i = countHexLeight; i >= 0; i--)
            {
                Console.Write(hexToChar[i]);
            }

        }
    }
}
