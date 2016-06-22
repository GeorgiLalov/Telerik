using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_area_in_matrix_2._0
{
    class Program
    {
        static int maxRow;
        static int maxCol;
        static int currentLeight;
        static int[,] matrix;
        static bool[,] isCellVisited;

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            maxRow = int.Parse(input[0]);
            maxCol = int.Parse(input[1]);
            currentLeight = 0;
            int maxLeight = int.MinValue;
            matrix = new int[maxRow, maxCol];
            isCellVisited = new bool[maxRow, maxCol];

            for (int row = 0; row < maxRow; row++)
            {
                string[] inputCol = Console.ReadLine().Split(' ');
                for (int col = 0; col < maxCol; col++)
                {
                    matrix[row, col] = int.Parse(inputCol[col]);
                }
            } // OK

            // check every non visited cell
            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol; col++)
                {
                    if (isCellVisited[row, col] == false )
                    {
                        checkNeighbours(row, col,  matrix[row, col]);
                        if (currentLeight > maxLeight)
                        {
                            maxLeight = currentLeight;
                        }
                        currentLeight = 0;
                    }
                }
            }

            Console.WriteLine(maxLeight);

        }

        static void checkNeighbours(int row, int col, int number)
        {
            if (row < 0 || row >= maxRow || col < 0 || col >= maxCol || isCellVisited[row, col] == true
                || matrix[row, col] != number)
            {
                return;
            }

            currentLeight++;
            isCellVisited[row, col] = true;
            checkNeighbours(row - 1, col, number); // UP
            checkNeighbours(row + 1, col, number); // DOWN
            checkNeighbours(row, col - 1, number); // LEFT
            checkNeighbours(row, col + 1,number); // RIGHT
            
        }
    }
}
