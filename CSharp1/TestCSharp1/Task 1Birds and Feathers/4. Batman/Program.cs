using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Batman
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int halfSize = size / 2;
            char ch = (char)Console.Read();
            char space = ' ';
            int count = 0;
            bool inside = false;

            for (int row = 0; row < 3 * halfSize - 1; row++)
            {
                for (int col = 0; col < 3 * size ; col++)
                {
                    if( row < halfSize && col < size)
                    {
                        if(row != 0 && col <= row - 1)
                            Console.Write(space);
                        else
                            Console.Write(ch);
                    }
                    else if(row < halfSize && col < size * 2)
                    {
                        if (row != halfSize - 1)
                            Console.Write(space);
                        else
                        {
                            if ((col >= size && col < size + halfSize - 1) || (col >= (size + halfSize + 2) && col < (2 * size)))
                                Console.Write(space);
                            else if( col == size + halfSize - 1 || col == size + halfSize + 1 )
                                Console.Write(ch);
                            else if( col == size + halfSize )
                                Console.Write(space);
                        }
                    }else if(row < halfSize && col < 3 * size)
                    {
                        if (row != 0 && col >= 3 * size - row)
                            Console.Write(space);
                        else
                            Console.Write(ch);
                    }else if( row < 2 * halfSize - 1)
                    {
                        if( col < halfSize || col > 2 * size + halfSize )
                            Console.Write(space);
                        else
                            Console.Write(ch);
                    }
                    else
                    {
                        if (col <= size + count || col > 2 * size - 2 - count)
                        {
                            inside = true;
                            Console.Write(space);
                        }
                        else
                            Console.Write(ch);
                    }
                }
                if (inside)
                    count++;
                Console.WriteLine();
            }
           
        }
    }
}
