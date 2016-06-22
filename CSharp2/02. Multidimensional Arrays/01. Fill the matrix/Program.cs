using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fill_the_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRowsCols = int.Parse(Console.ReadLine());
            char switchChar = (char) Console.Read();
            int[,] matrix = new int[numberOfRowsCols, numberOfRowsCols];

            switch (switchChar)
            {
                case 'a':   caseA(matrix, numberOfRowsCols);
                    break;
                case 'b':   caseB(matrix, numberOfRowsCols);
                    break;
                case 'c':   caseC(matrix, numberOfRowsCols);
                    break;
                case 'd':   caseD(matrix, numberOfRowsCols);
                    break;
                default:
                    break;
            }
        }

        static void printMatrix(int[,] matrix, int leight)
        {
            for (int row = 0; row < leight; row++)
            {
                for (int col = 0; col < leight; col++)
                {
                    if (col != 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void caseA(int[,] matrix, int leight)
        {
            for (int row = 0; row < leight; row++)
            {
                for (int col = 0; col < leight; col++)
                {
                    if (col == 0)
                    {
                        matrix[row, col] = row + 1;
                    }
                    else
                    {
                        matrix[row, col] = matrix[row, col - 1] + leight;
                    }
                }
            }

            printMatrix(matrix, leight);
        }

        static void caseB(int[,] matrix, int leight)
        {
            int countCurrentNum = 1;
            for (int col = 0; col < leight; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < leight; row++)
                    {
                        matrix[row, col] = countCurrentNum;
                        countCurrentNum++;
                    }
                }
                else
                {
                    for (int row = leight - 1; row >= 0; row--)
                    {
                        matrix[row, col] = countCurrentNum;
                        countCurrentNum++;
                    }
                }
            }

            printMatrix(matrix, leight);
        }

        static void caseC(int[,] matrix, int leight)
        {
            int row = leight - 1;
            int col = 0;
            int tempPreviousRow = row;
            int countCurrentNum = 1;

            // under diagonal
            while (row != 0)
            {
                if (row == leight - 1)
                {
                    matrix[row, col] = countCurrentNum;
                    countCurrentNum++;
                    row = tempPreviousRow - 1;
                    tempPreviousRow = row;
                    col = 0;
                }
                else 
                {
                    matrix[row, col] = countCurrentNum;
                    countCurrentNum++;
                    row++;
                    col++;
                }
            }

            // diaginal

            for (row = 0, col = 0; row < leight; row++, col++)
            {
                matrix[row, col] = countCurrentNum;
                countCurrentNum++;
            }

            // over diagonal

            row = 0;
            col = 1;
            int tempPreviousCol = col;
            while (col != leight)
            {
                if (col == leight - 1)
                {
                    matrix[row, col] = countCurrentNum;
                    countCurrentNum++;
                    col = tempPreviousCol + 1;
                    tempPreviousCol = col;
                    row = 0;
                }
                else
                {
                    matrix[row, col] = countCurrentNum;
                    countCurrentNum++;
                    row++;
                    col++;
                }
            }

            printMatrix(matrix, leight);
        }

        static void caseD(int[,] matrix, int leight)
        {
            int tempLeight = leight;
            int countCurrentNum = 1;
            int col = 0;
            int row = 0;

            for (int calibration = 0; tempLeight > 0; tempLeight -= 2, calibration++)
            {
                for (row = calibration, col = calibration; row < tempLeight + calibration; row++)
                {
                    matrix[row, col] = countCurrentNum;
                    countCurrentNum++;
                }

                for (col = 1 + calibration, row--; col <= tempLeight - 1 + calibration; col++)
                {
                    matrix[row, col] = countCurrentNum;
                    countCurrentNum++;
                }

                for (row--, col--; row >= calibration; row--)
                {
                    matrix[row, col] = countCurrentNum;
                    countCurrentNum++;
                }

                for (col--, row++; col >= calibration + 1; col--)
                {
                    matrix[row, col] = countCurrentNum;
                    countCurrentNum++;
                }
            }

            printMatrix(matrix, leight);
        }
    }
}
