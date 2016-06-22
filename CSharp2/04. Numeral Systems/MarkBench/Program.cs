using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MarkBench
{
    class Program
    {

        static void Main(string[] args)
        {
            int dec = 783;
            int system = 32;
            StringBuilder toOther = new StringBuilder();
            Stopwatch benchMark = new Stopwatch();

            benchMark.Start();
            DecToN(dec, system, toOther);
            benchMark.Stop();
            Console.WriteLine(toOther);
            Console.WriteLine(benchMark.Elapsed);

            benchMark.Restart();
            Console.WriteLine(DecimalToOther(dec, system));
            benchMark.Stop();
            Console.WriteLine(benchMark.Elapsed);


        }

        static void DecToN(int dec, int n, StringBuilder str)
        {
            string letters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (dec != 0)
            {
                DecToN(dec / n, n, str);
                str.Append(letters[dec % n]);
            }
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
