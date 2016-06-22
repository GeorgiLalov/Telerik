using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if(str == "integer")
                Console.WriteLine(int.Parse(Console.ReadLine()) + 1);
            else if (str == "real")
                Console.WriteLine("{0:F2}", double.Parse(Console.ReadLine()) + 1);
            else if (str == "text")
                Console.WriteLine(Console.ReadLine() + "*");
        }
    }
}
