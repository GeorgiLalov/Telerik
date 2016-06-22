namespace _03.Correct_brackets
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            char openBracket = '(';
            char closeBracket = ')';
            bool isTextCorrect = true;
            int countNumberOpenBrackets = 0;

            foreach (char letter in inputText)
            {
                if (letter == openBracket)
                {
                    countNumberOpenBrackets++;
                }else if (letter == closeBracket)
                {
                    countNumberOpenBrackets--;
                }

                if (countNumberOpenBrackets < 0)
                {
                    isTextCorrect = false;
                    break;
                }
            }

            if (countNumberOpenBrackets != 0)
            {
                isTextCorrect = false;
            }

            if (isTextCorrect)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
