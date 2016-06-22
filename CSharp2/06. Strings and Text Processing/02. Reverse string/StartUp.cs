namespace _02.Reverse_string
{
    using System;
    using System.Text;

    class StartUp
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            StringBuilder reverseStr = new StringBuilder();
            int length = inputText.Length;

            for (int index = length - 1; index >= 0; index--)
            {
                reverseStr.Append(inputText[index]);
            }

            Console.WriteLine(reverseStr);
        }
    }
}
