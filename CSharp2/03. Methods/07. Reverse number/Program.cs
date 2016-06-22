using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = reverseDigits(str);
            Console.WriteLine(str);
        }

        static string reverseDigits(string number)
        {
            char[] numChar = number.ToCharArray();
            int charLeight = numChar.Length - 1;
            int charLeightHalf = charLeight / 2;
            for (int index = 0; index <= charLeightHalf; index++)
            {
                char temp = numChar[charLeight - index];
                numChar[charLeight - index] = numChar[index];
                numChar[index] = temp;
            }

            return new string(numChar);
        }
    }
}
