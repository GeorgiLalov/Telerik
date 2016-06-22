using System;

namespace _4.Batman
{
    class Batman2
    {
        static int sizeFromConsole;
        static char characterFromConsole;
        static char spaceCharacter = ' ';
        static int halfSize;
        static int oneThirdSize;

        static void Main(string[] args)
        {
            sizeFromConsole = int.Parse(Console.ReadLine());
            characterFromConsole = (char)Console.Read();

            halfSize = sizeFromConsole / 2;
            oneThirdSize = sizeFromConsole / 3;

            drawHeadOfBatman();
            drawBodyOfBatman();
            drawEndOfBatman();
        }


        static void drawHeadOfBatman()
        {
            for (int row = 0; row < halfSize; row++)
            {
                Console.Write(new string(spaceCharacter, row));
                Console.Write(new string( characterFromConsole, sizeFromConsole - row ));
                if (row != halfSize - 1)
                {
                    Console.Write(new string( spaceCharacter, sizeFromConsole ));
                }
                else
                {
                    int spaceLeftForCharacterSpace = (sizeFromConsole - 3) / 2;
                    Console.Write(new string( spaceCharacter, spaceLeftForCharacterSpace));
                    Console.Write("{0}{1}{0}", characterFromConsole, spaceCharacter);
                    Console.Write(new string(spaceCharacter, spaceLeftForCharacterSpace));
                }
                Console.Write(new string(characterFromConsole, sizeFromConsole - row));
                Console.Write(new string(spaceCharacter, row));
                Console.WriteLine();
            }
        }

        static void drawBodyOfBatman()
        {
            for (int row = 0; row < oneThirdSize; row++)
            {
                int countCharacterToBePrinted = (3 * sizeFromConsole) - (2 * halfSize);
                Console.Write(new string(spaceCharacter, halfSize));
                Console.Write(new string(characterFromConsole, countCharacterToBePrinted));
                Console.Write(new string(spaceCharacter, halfSize));
                Console.WriteLine();
            }
        }

        static void drawEndOfBatman()
        {
            for (int row = 0; row < halfSize; row++)
            {
                int countSpaceCharactersToBePrinted = sizeFromConsole + row + 1;
                Console.Write(new string(spaceCharacter, countSpaceCharactersToBePrinted));
                Console.Write(new string(characterFromConsole, (3 * sizeFromConsole) - (2 * countSpaceCharactersToBePrinted)));
                Console.Write(new string(spaceCharacter, countSpaceCharactersToBePrinted));
                Console.WriteLine();
            }
        }
    }
}
