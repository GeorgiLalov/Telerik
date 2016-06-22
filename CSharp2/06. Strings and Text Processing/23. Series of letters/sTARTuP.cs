namespace _23.Series_of_letters
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();
            char previousChar = '\0';

            foreach (char letter in input)
            {
                if (letter != previousChar)
                {
                    text.Append(letter);
                    previousChar = letter;
                }
            }

            Console.WriteLine(text);
        }
    }
}
