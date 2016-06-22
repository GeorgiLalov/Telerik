using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hexadecimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(HexademicalToBinary(input));
        }

        static string HexademicalToBinary(string hexademical)
        {
            string binary = "";

            foreach (char index in hexademical)
            {
                binary += dictionary[index];
            }

            // remove begin zeroes
            while (binary.StartsWith("0"))
            {
                binary=binary.Substring(1);
            }

            return binary;
        }

        static Dictionary<char, string> dictionary = new Dictionary<char, string> {
            { '0', "0000" },
            { '1', "0001" },
            { '2', "0010" },
            { '3', "0011" },
            { '4', "0100" },
            { '5', "0101" },
            { '6', "0110" },
            { '7', "0111" },
            { '8', "1000" },
            { '9', "1001" },
            { 'A', "1010" },
            { 'B', "1011" },
            { 'C', "1100" },
            { 'D', "1101" },
            { 'E', "1110" },
            { 'F', "1111" }
        };
    }
}
