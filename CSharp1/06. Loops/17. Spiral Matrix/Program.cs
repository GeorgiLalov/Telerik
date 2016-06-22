using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int tempI = 0;
            int tempY = 0;
            int bonus = 0;
            int prBonus = 0;
            bool inside = false;

            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (inside)
                        tempY++;
                    
                    if (tempY > temp - 1)                    
                        inside = false;
                   
                    if (!inside)
                    {
                        temp = n;
                        tempI = i;
                        tempY = y;
                        bonus = 0;
                        prBonus = 0;
                    }

                    do
                    {
                        if ((tempI != 0 && tempI != temp - 1) && (tempY != 0 && tempY != temp - 1))
                        {
                            temp -= 2;
                            tempI = tempI - 1;
                            tempY = tempY - 1;
                            bonus = temp * 4 + 4 + prBonus;
                            prBonus = bonus;
                            inside = true;
                        }
                    } while (tempI != 0 && tempI != temp - 1 && tempY != 0 && tempY != temp - 1);

                    if (n % 2 == 1 && n / 2 == i && i == y)
                        Console.Write(n * n + " ");
                    else if (tempI == 0)
                        Console.Write(tempY + 1 + bonus + " ");
                    else if(tempI == temp - 1)
                        Console.Write(3 * temp - 2 - tempY + bonus + " ");
                    else if( tempY == temp - 1 )
                        Console.Write(temp + tempI + bonus + " ");
                    else if( tempY == 0)
                        Console.Write( temp * 4 - 3 - tempI + bonus + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
