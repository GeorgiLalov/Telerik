﻿using System;

class OddOrEven
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        if( number % 2 == 0)
            Console.WriteLine("even {0}", number);
        else
            Console.WriteLine("odd {0}", number);
    }
}

