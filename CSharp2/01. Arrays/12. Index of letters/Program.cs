using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            for (int index = 0; index < word.Length; index++)
            {
                Console.WriteLine(word[index] - 'a');
            }
        }
    }
}
