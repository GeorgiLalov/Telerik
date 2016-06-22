namespace _10.Unicode_characters
{
    using System;
    using System.Text;

    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string unicodeString = GetUnicodeString(input);

            Console.WriteLine(unicodeString);
        }

        static string GetUnicodeString(string textString)
        {
            StringBuilder unicodeString = new StringBuilder();
            foreach (char character in textString)
            {
                unicodeString.Append("\\u");
                unicodeString.Append(String.Format("{0:X4}", (int)character));
            }
            return unicodeString.ToString();
        }
    }
}
