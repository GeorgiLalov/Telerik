using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_as_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lengthInput = Console.ReadLine().Split(' ');
            int firstNumLength = int.Parse(lengthInput[0]);
            int secondNumLength = int.Parse(lengthInput[1]);
            string[] firstInput = Console.ReadLine().Split(' ');
            string[] secondInput = Console.ReadLine().Split(' ');
            int[] firstArr = CreateArray(firstInput, firstNumLength);
            int[] secondArr = CreateArray(secondInput, secondNumLength);
            int[] sumArr;

            if (firstNumLength > secondNumLength)
            {
                sumArr = AddTwoNums(firstArr, firstNumLength, secondArr, secondNumLength);
            }
            else
            {
                sumArr = AddTwoNums(secondArr, secondNumLength, firstArr, firstNumLength);
            }

            int length = sumArr.Length;
            for (int index = 0; index < length; index++)
            {
                if (sumArr[index] == 0 && index == length - 1)
                {
                    break;
                }
                else
                {
                    Console.Write("{0} ", sumArr[index]);
                }
            }

            Console.WriteLine();

        }

        static int[] CreateArray(string[] input, int arrLength)
        {
            int[] array = new int[arrLength];

            for (int index = 0; index < arrLength; index++)
            {
                array[index] = int.Parse(input[index]);
            }

            return array;
        }

        // firstArrLength > secondArrLength
        static int[] AddTwoNums(int[] firstArr, int firstLength, int[] secondArr, int secondLength)
        {
            int[] sumArr = new int[firstLength + 1];
            int remainder = 0;

            for (int index = 0; index < secondLength; index++)
            {
                int sum = firstArr[index] + secondArr[index] + remainder;
                if (sum > 9)
                {
                    remainder = 1;
                    sum %= 10;
                }
                else
                {
                    remainder = 0;
                }
                sumArr[index] = sum;

            }

            for (int index = secondLength; index < firstLength; index++)
            {
                int sum = firstArr[index] + remainder;
                if (sum > 9)
                {
                    remainder = 1;
                    sum %= 10;
                }
                else
                {
                    remainder = 0;
                }
                sumArr[index] = sum;
            }

            if (remainder == 1)
            {
                sumArr[firstLength] = 1;
            }

            return sumArr;
        }

    }
}
