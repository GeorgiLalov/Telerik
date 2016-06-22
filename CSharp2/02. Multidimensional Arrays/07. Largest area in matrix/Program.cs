using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  30/100
 */

namespace _03.Sequence_in_matrix
{
    class ListOfNumbers
    {
        public int number;
        public int count;
    }
    class Program
    {
        static List<ListOfNumbers> listCountEqualNeighbours;
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int maxRow = int.Parse(input[0]);
            int maxCol = int.Parse(input[1]);
            int[,] matrix = new int[maxRow, maxCol];
            int maxVisitedCell = int.MinValue;
            listCountEqualNeighbours = new List<ListOfNumbers>();
            bool[,] isMatrixCellVisited = new bool[maxRow, maxCol];
            int breakerCountForIsVisited = maxRow * maxCol;
            int countVisitedCells = 0;

            for (int row = 0; row < maxRow; row++)
            {
                string[] inputCol = Console.ReadLine().Split(' ');
                for (int col = 0; col < maxCol; col++)
                {
                    matrix[row, col] = int.Parse(inputCol[col]);
                }
            } // OK

            // search rows

            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        if (isMatrixCellVisited[row, col] == false) {
                            addCountToList(matrix[row, col]);
                            isMatrixCellVisited[row, col] = true;
                            countVisitedCells++;
                        }
                        if (isMatrixCellVisited[row, col + 1] == false)
                        {
                            addCountToList(matrix[row, col]);
                            isMatrixCellVisited[row, col + 1] = true;
                            countVisitedCells++;
                        }
                    }
                }
                
            }

            // search columns

            for (int col = 0; col < maxCol; col++)
            {
                if (countVisitedCells == breakerCountForIsVisited)
                {
                    break;
                }
                for (int row = 0; row < maxRow - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        if (isMatrixCellVisited[row, col] == false)
                        {
                            addCountToList(matrix[row, col]);
                            isMatrixCellVisited[row, col] = true;
                            countVisitedCells++;
                        }
                        if (isMatrixCellVisited[row + 1, col] == false)
                        {
                            addCountToList(matrix[row, col]);
                            isMatrixCellVisited[row + 1, col] = true;
                            countVisitedCells++;
                        }
                    }
                }
                
            }

            // search basic diagonal

            for (int everyRow = 0; everyRow < maxRow - 1; everyRow++)
            {
                if (countVisitedCells == breakerCountForIsVisited)
                {
                    break;
                }
                for (int everyCol = 0; everyCol < maxCol - 1; everyCol++)
                {
                    for (int row = everyRow, col = everyCol; (row < maxRow - 1) && (col < maxCol - 1); row++, col++)
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            if (isMatrixCellVisited[row, col] == false)
                            {
                                addCountToList(matrix[row, col]);
                                isMatrixCellVisited[row, col] = true;
                                countVisitedCells++;
                            }
                            if (isMatrixCellVisited[row + 1, col + 1] == false)
                            {
                                addCountToList(matrix[row, col]);
                                isMatrixCellVisited[row + 1, col + 1] = true;
                                countVisitedCells++;
                            }
                        }
                    }
                }
            }

            // search other diagonal
            for (int everyRow = 0; everyRow < maxRow - 1; everyRow++)
            {
                if (countVisitedCells == breakerCountForIsVisited)
                {
                    break;
                }
                for (int everyCol = 1; everyCol < maxCol; everyCol++)
                {
                    for (int row = everyRow, col = everyCol; (row < maxRow - 1) && (col > 0); row++, col--)
                    {
                        if (matrix[row, col] == matrix[row + 1, col - 1])
                        {
                            if (isMatrixCellVisited[row, col] == false)
                            {
                                addCountToList(matrix[row, col]);
                                isMatrixCellVisited[row, col] = true;
                                countVisitedCells++;
                            }
                            if (isMatrixCellVisited[row + 1, col - 1] == false)
                            {
                                addCountToList(matrix[row, col]);
                                isMatrixCellVisited[row + 1, col - 1] = true;
                                countVisitedCells++;
                            }
                        }
                    }
                }
            }

            // Search for the biggest visite cell end print it
            for (int index = 0; index < listCountEqualNeighbours.Count; index++)
            {
                if (listCountEqualNeighbours[index].count > maxVisitedCell)
                {
                    maxVisitedCell = listCountEqualNeighbours[index].count;
                }
            }
                     
            Console.WriteLine(maxVisitedCell);
        }

        static void addCountToList(int number)
        {
            int listLeight = listCountEqualNeighbours.Count;
            if (listLeight == 0)
            {
                ListOfNumbers newElement = new ListOfNumbers();
                newElement.count = 1;
                newElement.number = number;
                listCountEqualNeighbours.Add(newElement);
            }
            else
            {
                for (int index = 0; index < listLeight; index++)
                {
                    if (listCountEqualNeighbours[index].number == number)
                    {
                        listCountEqualNeighbours[index].count++;
                        break;
                    }
                    if (index == listLeight - 1)
                    {
                        ListOfNumbers newElement = new ListOfNumbers();
                        newElement.count = 1;
                        newElement.number = number;
                        listCountEqualNeighbours.Add(newElement);
                    }
                }
            }
        }
    }
}
