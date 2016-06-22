using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            char c = Convert.ToChar(Console.Read());
            int n = s;
            int n1 = 0;
            int d = 0;
            int m = 0;
            if (s == 5) { d = s / 3; m = d + 1; }
            else if (s > 5 && s < 10)
            {
                d = (s / 4) + 1;
                m = d + 1;
            }
            else if (s > 10 && s < 20)
            {
                d = (s / 4) + 2;
                m = d + 1;
            }
            else if (s > 20 && s < 30)
            {
                if (s == 21) { d = (s / 4) + 4; m = d + 1; }
                else if (s > 21 && s <= 25) { d = (s / 4) + 5; m = d + 1; }
                else if (s > 25) { d = (s / 4) + 6; m = d + 1; }
            }
            else if (s > 30 && s < 40)
            {
                if (s == 31) { d = (s / 4) + 7; m = d + 1; }
                else if (s > 31 && s <= 33) { d = (s / 4) + 7; m = d + 2; }
                else if (s == 35) { d = (s / 4) + 8; m = d + 1; }
                else if (s > 35) { d = (s / 4) + 8; m = d + 2; }
            }
            else if (s > 40 && s < 50)
            {
                if (s == 41) { d = (s / 4) + 9; m = d + 2; }
                else if (s > 41 && s <= 45) { d = (s / 4) + 10; m = d + 2; }
                else if (s > 45) { d = (s / 4) + 11; m = d + 2; }
            }
            else if (s == 51) { d = (s / 4) + 12; m = d + 2; }
            for (int i = 0; i < (s / 2) - 1; i++)
            {
                Console.WriteLine(new string(' ', n1) + new string(c, n) + new string(' ', s) + new string(c, n));
                n--;
                n1++;
            }
            Console.WriteLine(new string(' ', n1) + new string(c, n) + new string(' ', d) + c + " " + c + new string(' ', d) + new string(c, n));
            n--;
            n1++;
            for (int i = 0; i < s / 3; i++)
            {
                Console.WriteLine(new string(' ', n1) + new string(c, n) + new string(c, s) + new string(c, n));
            }
            int k = s + 1;
            int k2 = s - 2;
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(new string(' ', k) + new string(c, k2));
                k++;
                k2 = k2 - 2;
            }

        }
    }
}
