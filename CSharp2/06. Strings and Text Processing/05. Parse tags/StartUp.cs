namespace _05.Parse_tags
{
    using System;
    using System.Text;

    class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] tags = { "<upcase>", "</upcase>" };

            string[] splitText = text.Split(tags, StringSplitOptions.None);
            StringBuilder str = new StringBuilder();

            for (int index = 0; index < splitText.Length; index++)
            {
                if (index % 2 == 1)
                {
                    splitText[index] = splitText[index].ToUpper();
                }

                str.Append(splitText[index]);
            }

            Console.WriteLine(str);
        }
    }
}
