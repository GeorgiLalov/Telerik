using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int maxRow = int.Parse(input[0]);
            int maxCol = int.Parse(input[1]);
            int[,] matrix = new int[maxRow, maxCol];
            int currentSum = 0;
            int maxSum = int.MinValue;
            int squareNum = 3;

            for (int row = 0; row < maxRow; row++)
            {
                string[] inputCol = Console.ReadLine().Split(' ');
                for (int col = 0; col < maxCol; col++)
                {
                    matrix[row, col] = int.Parse(inputCol[col]);
                }
            }

            for (int row = 0; row < maxRow - squareNum + 1; row++)
            {
                for (int col = 0; col < maxCol - squareNum + 1; col++)
                {
                    for (int insideRow = row; insideRow < squareNum + row; insideRow++)
                    {
                        for (int insideCol = col; insideCol < squareNum + col; insideCol++)
                        {
                            currentSum += matrix[insideRow, insideCol];
                        }
                    }

                    if (currentSum >= maxSum)
                    {
                        maxSum = currentSum;
                    }

                    currentSum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
