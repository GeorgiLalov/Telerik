namespace _07.Encode_and_Decode
{
    using System;
    using System.Text;

    class StartUp
    {
        static string EncodeDecode(string text, string cipher)
        {
            StringBuilder encodedDecodedText = new StringBuilder();
            int cipherLength = cipher.Length;
            int textLength = text.Length;

            for (int index = 0; index < textLength; index++)
            {
                char charToAppend = (char)(text[index] ^ cipher[index % cipherLength]);
                encodedDecodedText.Append(charToAppend);
            }

            return encodedDecodedText.ToString();
        }

        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string cipher = Console.ReadLine();

            string encode = EncodeDecode(inputText, cipher);
            string decode = EncodeDecode(encode, cipher);

            Console.WriteLine(encode);
            Console.WriteLine(decode);
        }
    }
}
