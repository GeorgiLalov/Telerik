using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().ToCharArray();
            char[] secondArr = Console.ReadLine().ToCharArray();
            int minArrLeight = 0;
            bool isEqual = false;
            bool isPrinted = false;

            if (firstArr.Length == secondArr.Length)
            {
                minArrLeight = secondArr.Length;
                isEqual = true;
            }
            else if (firstArr.Length > secondArr.Length)
            {
                minArrLeight = secondArr.Length;
            }
            else
            {
                minArrLeight = firstArr.Length;
            }

            for (int index = 0; index < minArrLeight; index++)
            {
                if (firstArr[index] > secondArr[index])
                {
                    Console.WriteLine(">");
                    isPrinted = true;
                    break;
                }
                else if (firstArr[index] < secondArr[index])
                {
                    Console.WriteLine("<");
                    isPrinted = true;
                    break;
                }
            }

            if (!isPrinted)
            {
                if (isEqual)
                {
                    Console.WriteLine("=");
                }
                else if (firstArr.Length > secondArr.Length)
                {
                    Console.WriteLine(">");
                }
                else
                {
                    Console.WriteLine("<");
                }

            }

        }
    }
}
