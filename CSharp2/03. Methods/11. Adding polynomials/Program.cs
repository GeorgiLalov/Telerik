using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            string[] firstInput = Console.ReadLine().Split(' ');
            string[] secondInput = Console.ReadLine().Split(' ');
            int[] firstArr = CreateArray(firstInput, arrLength);
            int[] secondArr = CreateArray(secondInput, arrLength);

            int[] arrSum = PolynomSum(firstArr, secondArr, arrLength);

            foreach (int element in arrSum)
            {
                Console.Write("{0} ", element);
            }
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

        static int[] PolynomSum(int[] firstArr, int[] secondArr, int arrLength)
        {
            int[] arrSum = new int[arrLength];

            for (int index = 0; index < arrLength; index++)
            {
                arrSum[index] = firstArr[index] + secondArr[index];
            }

            return arrSum;
        }
    }
}
