using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int widtHeight = 2 * n + 1;
            int centerRowCol = widtHeight / 2;
            //int spaceLeft = 2 * d 

            for (int row = 0; row < widtHeight; row++)
            {
                for (int col = 0; col < widtHeight; col++)
                {
                    if (row == centerRowCol && col == centerRowCol)
                        Console.Write('X');
                    else if (row == col)
                        Console.Write('\\');
                    else if ((row + col) == (widtHeight - 1))
                        Console.Write('/');
                    else if ((row > col && (row + col) < widtHeight) || (row < col && (row + col) > (widtHeight - 1)))
                        Console.Write('#');
                    else if (col != centerRowCol && ((row + 1 + d == col) || (col + 1 + d == row)))
                        Console.Write('\\');
                    else if (col != centerRowCol && ((row + col) == (widtHeight - 2 - d) || (row + col) == widtHeight + d))
                        Console.Write('/');
                    else if (row != centerRowCol - 1 && row != centerRowCol + 1)
                        Console.Write('.');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }

        }
    }
}
