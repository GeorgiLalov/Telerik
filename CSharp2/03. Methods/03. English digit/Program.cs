using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string lastNumStr = GetLastNum(number);
            Console.WriteLine(lastNumStr);
        }

        static string GetLastNum(int number)
        {
            int lastNum = number % 10;
            string lastNumStr = "";

            switch (lastNum)
            {
                case 0: lastNumStr = "zero"; break;
                case 1: lastNumStr = "one"; break;
                case 2: lastNumStr = "two"; break;
                case 3: lastNumStr = "three"; break;
                case 4: lastNumStr = "four"; break;
                case 5: lastNumStr = "five"; break;
                case 6: lastNumStr = "six"; break;
                case 7: lastNumStr = "seven"; break;
                case 8: lastNumStr = "eight"; break;
                case 9: lastNumStr = "nine"; break;
            }

            return lastNumStr;
        }
    }
}
