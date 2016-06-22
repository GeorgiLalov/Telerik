namespace _04.Sub_string_in_text
{
    using System;

    class StarpUp
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int repeatingCount = 0;
            int patternLength = pattern.Length;
            int textLength = text.Length;

            for(int index = 0; index < textLength - patternLength + 1; index++)
            {
                if (text.Substring(index, patternLength).Equals(pattern))
                {
                    repeatingCount++;
                }
            }

            Console.WriteLine(repeatingCount);
        }
    }
}
