using System;

class PrintASCII
{
    static void Main(string[] args)
    {
        for(char c = '\u0021'; c < '\u007F'; c++)
            Console.Write(c);
    }
}