using System;

namespace _4.Malko_Kote
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeConsole = int.Parse(Console.ReadLine());
            char characterConsole = (char)Console.Read();
            char spaceCharacter = '.'; // TODO change to ' '
            int oneThirdOfcharCons = sizeConsole / 3;
            int calcNum = oneThirdOfcharCons - 2; ;

            // draw head
            for (int row = 0; row < calcNum + 1; row++)
            {
                Console.Write(spaceCharacter);
                Console.Write(characterConsole);
                if (row == 0)
                {
                    Console.Write(new string(spaceCharacter, calcNum));
                }
                else
                {
                    Console.Write(new string(characterConsole, calcNum));
                }
                
                Console.Write(characterConsole);
                Console.Write(new string(spaceCharacter, oneThirdOfcharCons + 2));
                Console.WriteLine();
            }        

            // end draw head

            // draw neck

            for (int row = 0; row < calcNum; row++)
            {
                Console.Write(new string(spaceCharacter, 2));
                Console.Write(new string(characterConsole, calcNum));
                Console.Write(new string(spaceCharacter, oneThirdOfcharCons + 3));
                Console.WriteLine();
            }

            //end draw neck
        }
    }
}
