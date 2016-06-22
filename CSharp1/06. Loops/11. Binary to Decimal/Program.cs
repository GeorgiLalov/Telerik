using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            int lenght = binary.Length;
            int count = 1;
            long dec = 0;

            for (int i = lenght - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                    dec += count;
                count *= 2;
            }

            Console.WriteLine(dec);
        }
    }
}
