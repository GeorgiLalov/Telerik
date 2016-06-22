using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Say_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();
        }

        static void PrintName()
        {
            Console.WriteLine("Hello, {0}!", Console.ReadLine());
        }
    }
}
