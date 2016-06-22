using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Get_largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int firstNum = int.Parse(input[0]);
            int secondNum = int.Parse(input[1]);
            int thirdNum = int.Parse(input[2]);

            int maxNum = GetMax(firstNum, secondNum);
            maxNum = GetMax(maxNum, thirdNum);
            Console.WriteLine(maxNum);
        }

        static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
    }
}
