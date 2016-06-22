using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sequence_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int maxRow = int.Parse(input[0]);
            int maxCol = int.Parse(input[1]);
            string[,] matrix = new string[maxRow, maxCol];
            int currentLeight = 1;
            int maxLeight = int.MinValue;

            for (int row = 0; row < maxRow; row++)
            {
                string[] inputCol = Console.ReadLine().Split(' ');
                for (int col = 0; col < maxCol; col++)
                {
                    matrix[row, col] = inputCol[col];
                }
            }

            // search rows

            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        currentLeight++;
                        if (currentLeight > maxLeight)
                        {
                            maxLeight = currentLeight;
                        }
                    }
                    else
                    {
                        if (currentLeight > maxLeight)
                        {
                            maxLeight = currentLeight;
                        }
                        currentLeight = 1;
                    }
                }

                if (currentLeight > maxLeight)
                {
                    maxLeight = currentLeight;
                }
                currentLeight = 1;
            }

            // search columns

            for (int col = 0; col < maxCol; col++)
            {
                for (int row = 0; row < maxRow - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currentLeight++;
                        if (currentLeight > maxLeight)
                        {
                            maxLeight = currentLeight;
                        }
                    }
                    else
                    {
                        if (currentLeight > maxLeight)
                        {
                            maxLeight = currentLeight;
                        }
                        currentLeight = 1;
                    }
                }

                if (currentLeight > maxLeight)
                {
                    maxLeight = currentLeight;
                }
                currentLeight = 1;
            }

            // search basic diagonal

            for (int everyRow = 0; everyRow < maxRow - 1; everyRow++)
            {
                for (int everyCol = 0; everyCol < maxCol - 1; everyCol++)
                {
                    for (int row = everyRow, col = everyCol; (row < maxRow - 1) && (col < maxCol - 1); row++, col++)
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            currentLeight++;
                            if (currentLeight > maxLeight)
                            {
                                maxLeight = currentLeight;
                            }
                        }
                        else
                        {
                            if (currentLeight > maxLeight)
                            {
                                maxLeight = currentLeight;
                            }
                            currentLeight = 1;
                        }
                    }
                }
            }

            // search other diagonal
            for (int everyRow = 0; everyRow < maxRow - 1; everyRow++)
            {
                for (int everyCol = 1; everyCol < maxCol; everyCol++)
                {
                    for (int row = everyRow, col = everyCol ; (row < maxRow - 1) && (col > 0); row++, col--)
                    {
                        if (matrix[row, col] == matrix[row + 1, col - 1])
                        {
                            currentLeight++;
                            if (currentLeight > maxLeight)
                            {
                                maxLeight = currentLeight;
                            }
                        }
                        else
                        {
                            if (currentLeight > maxLeight)
                            {
                                maxLeight = currentLeight;
                            }
                            currentLeight = 1;
                        }
                    }
                }
            }

            Console.WriteLine(maxLeight);
        }
    }
}
