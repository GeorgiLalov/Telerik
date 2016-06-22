using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Print_a_Deck
{
    class Program
    {
        static void Main(string[] args)
        {
            int card = Console.Read();

            if (card == 49)
            {
                for (int i = '2'; i <= 57; i++)
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", (char)i);
                Console.WriteLine("10 of spades, 10 of clubs, 10 of hearts, 10 of diamonds");

            }
            else {

                for (int i = '2'; i <= card && i <= 57 ; i++)
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", (char)i);
                

                if (card > 57)
                {
                    Console.WriteLine("10 of spades, 10 of clubs, 10 of hearts, 10 of diamonds");
                    if (card > 64)
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    if (card != 74 && card > 64 && card < 82)
                        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    if (card == 75 || card == 65)
                        Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                    if (card == 65)
                        Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");

                }
            }
        }
    }
}
