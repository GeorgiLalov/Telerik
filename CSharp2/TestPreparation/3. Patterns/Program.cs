using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Patterns
{
    class Program
    {
        static long[,] GetMatrix(int n)
        {
            long[,] matrix = new long[n, n];

            for (int index = 0; index < n; index++)
            {
                long[] row = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[index, col] = row[col];
                }
            }

            return matrix;
        }

        static long GetDiagonalSum(long[,] matrix, int n)
        {
            long diagonalSum = 0;

            for (int row = 0, col = 0; row < n; row++, col++)
            {
                diagonalSum += matrix[row, col];
            }

            return diagonalSum;
        }



        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[,] matrix = GetMatrix(n);
            bool hasPattern = false;
            long sum = long.MinValue;

            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < n - 4; col++)
                {
                    // logic
                    int currentRow = row;
                    int currentCol = col;
                    long currentSum = matrix[currentRow, currentCol];
                    bool currentHasPattern = true;

                    for (int count = 0; count < 2; count++)
                    {
                        if (matrix[currentRow, currentCol] != matrix[currentRow, currentCol + 1] - 1)
                        {
                            currentHasPattern = false;
                            break;
                        }

                        currentSum += matrix[currentRow, currentCol + 1];
                        currentCol++;
                    }
                    
                    for (int count = 0; count < 2; count++)
                    {
                        if (currentHasPattern == false)
                        {
                            break;
                        }
                        if (matrix[currentRow, currentCol] != matrix[currentRow + 1, currentCol] - 1)
                        {
                            currentHasPattern = false;
                            break;
                        }

                        currentSum += matrix[currentRow + 1, currentCol];
                        currentRow++;
                    }

                    for (int count = 0; count < 2; count++)
                    {
                        if (currentHasPattern == false)
                        {
                            break;
                        }
                        if (matrix[currentRow, currentCol] != matrix[currentRow, currentCol + 1] - 1)
                        {
                            currentHasPattern = false;
                            break;
                        }

                        currentSum += matrix[currentRow, currentCol + 1];
                        currentCol++;
                    }

                    if (currentHasPattern == true)
                    {
                        hasPattern = true;
                        if (currentSum > sum)
                        {
                            sum = currentSum;
                        }
                    }

                    // end logic
                }
            }

            if (hasPattern)
            {
                Console.WriteLine("YES {0}", sum);
            }
            else
            {
                Console.WriteLine("NO {0}", GetDiagonalSum(matrix, n));
            }
        }
    }
}
