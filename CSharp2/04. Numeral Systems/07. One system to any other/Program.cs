﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.One_system_to_any_other
{
    class Program
    {
        static void Main()
        {
            int inputBase = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int outputBase = int.Parse(Console.ReadLine());

            Console.WriteLine(DecimalToOther(OtherToDecimal(number, inputBase), outputBase));
        }
        public static long OtherToDecimal(string number, int baseS)
        {
            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (String.IsNullOrEmpty(number))
                return 0;

            number = number.ToUpperInvariant();

            long result = 0;
            long multiplier = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                char c = number[i];
                if (i == 0 && c == '-')
                {
                    result = -result;
                    break;
                }

                int digit = digits.IndexOf(c);

                result += digit * multiplier;
                multiplier *= baseS;
            }

            return result;
        }
        public static string DecimalToOther(long decimalNumber, int baseD)
        {
            const int bitsInLong = 64;
            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (decimalNumber == 0)
                return "0";

            int index = bitsInLong - 1;
            long currentNum = Math.Abs(decimalNumber);
            char[] charArr = new char[bitsInLong];

            while (currentNum != 0)
            {
                int remainder = (int)(currentNum % baseD);
                charArr[index--] = digits[remainder];
                currentNum = currentNum / baseD;
            }

            string result = new String(charArr, index + 1, bitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }
    }
}
