namespace _12.Parse_URL
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(new string[] { "://" }, StringSplitOptions.None);
            string protocol = splitInput[0];
            string serverAndResource = splitInput[1];
            int countServerCharacters = 0;

            foreach (char letter in serverAndResource)
            {
                if (letter == '/')
                {
                    break;
                }
                countServerCharacters++;
            }

            string server = serverAndResource.Substring(0, countServerCharacters);
            string resource = serverAndResource.Substring(countServerCharacters);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
