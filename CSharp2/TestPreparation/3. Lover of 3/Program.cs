namespace _3.Lover_of_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {

        static long[,] GetArray(int maxRow, int maxCol)
        {
            long[,] array = new long[maxRow, maxCol];

            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol; col++)
                {
                    array[row, col] = (maxRow - 1 - row) * 3 + col * 3;
                }
            }
            return array;
        }

        static long GetSum (long[,] matrix, string[] instructions, int[] arrayStep)
        {
            int maxRow = matrix.GetLength(0);
            int maxCol = matrix.GetLength(1);
            long sum = 0;
            bool[,] IsVisit = new bool[maxRow, maxCol];
            int row = maxRow - 1;
            int col = 0;

            for (int index = 0; index < instructions.Length; index++)
            {
                for (int count = 1; count < arrayStep[index]; count++)
                {
                    int tempRow = row;
                    int tempCol = col;
                    switch (instructions[index])
                    {
                        case "RU":
                        case "UR":
                            row--;
                            col++;
                            break;
                        case "LU":
                        case "UL":
                            row--;
                            col--;
                            break;
                        case "DL":
                        case "LD":
                            row++;
                            col--;
                            break;
                        case "RD":
                        case "DR":
                            row++;
                            col++;
                            break;
                        default:
                            break;
                    }

                    if (row >= maxRow || col >= maxCol || row < 0 || col < 0)
                    {
                        row = tempRow;
                        col = tempCol;
                        break;
                    }
                    else
                    {
                        if (!IsVisit[row, col])
                        {
                            sum += matrix[row, col];
                            IsVisit[row, col] = true;
                        }
                    }
                }

            }

            return sum;
        }
        
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long[,] matrix = GetArray(rowCol[0], rowCol[1]);
            int n = int.Parse(Console.ReadLine());
            string[] instructions = new string[n];
            int[] arrayStep = new int[n];

            for (int count = 0; count < n; count++)
            {
                string[] input = Console.ReadLine().Split(' ');
                instructions[count] = input[0];
                arrayStep[count] = int.Parse(input[1]);
            }

            long sum = GetSum(matrix, instructions, arrayStep);

            Console.WriteLine(sum);

        }
    }
}
