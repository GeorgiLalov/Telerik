using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TRES4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong inputDec = ulong.Parse(Console.ReadLine());

            Console.WriteLine(DecimalToAlien(inputDec));
        }

        static string DecimalToAlien(ulong dec)
        {
            string alien = "";
            ulong alienBase = 9;
            string[] alienChars =
            {
                "LON+", "VK-", "*ACAD", "^MIM" ,"ERIK|" ,"SEY&" ,"EMY>>" ,"/TEL" ,"<<DON"
            };

            
            do{
                alien = alienChars[dec % alienBase] + alien;
                dec /= alienBase;
            } while (dec != 0) ;

                return alien;
        }
    }
}
