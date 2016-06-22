using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Binary_to_hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(BinaryToHexadecimal(input));
        }

        static string BinaryToHexadecimal(string binary)
        {
            string hex = "";

            for (int index = binary.Length - 1; index >= 0; index -= 4)
            {
                string word;
                if (index - 3 < 0)
                {
                    word = binary.Substring(0, index + 1);
                    while (word.Length != 4)
                    {
                        word = '0' + word;
                    }
                }
                else
                {
                    word = binary.Substring(index - 3, 4);
                }

                hex = dictionary[word] + hex;
            }

            return hex;
        }

        static Dictionary<string, char> dictionary = new Dictionary<string, char> {
            { "0000", '0' },
            { "0001", '1' },
            { "0010", '2' },
            { "0011", '3' },
            { "0100", '4' },
            { "0101", '5' },
            { "0110", '6' },
            { "0111", '7' },
            { "1000", '8' },
            { "1001", '9' },
            { "1010", 'A' },
            { "1011", 'B' },
            { "1100", 'C' },
            { "1101", 'D' },
            { "1110", 'E' },
            { "1111", 'F' }
        };
    }
}
