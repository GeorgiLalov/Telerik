using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Program that sort an array of strings by the leight of the strings
 * NOT FINISHED
 */

namespace _05.Sort_by_string_length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array leight : ");
            int arrLeight = int.Parse(Console.ReadLine());
            string[] arrayOfStrings = new string[arrLeight];
            Console.WriteLine("Input the elements of the array on a new line!");

            for (int index = 0; index < arrLeight; index++)
            {
                arrayOfStrings[index] = Console.ReadLine();
            }

            // end input
            // begin sorting

            // array for saving the leights of the strings of the arrayOfStrings
            int[] collectLeightsOfStrings = new int[arrLeight];

            for (int index = 0; index < arrLeight; index++)
            {
                collectLeightsOfStrings[index] = arrayOfStrings[index].Length;
            }
            Array.Sort(collectLeightsOfStrings);
            string[] sortedArrayOfStrings = new string[arrLeight];

            /**
             * TODO : If the leight is equal there is a problem
             * The elements arent coping right!!!
             */

            for (int index = 0; index < arrLeight; index++)
            {
                for (int indexOfString = 0; indexOfString < arrLeight; indexOfString++)
                {
                    if (collectLeightsOfStrings[index] == arrayOfStrings[indexOfString].Length)
                    {
                        sortedArrayOfStrings[index] = arrayOfStrings[indexOfString];
                        break;
                    }
                }
            }

            Console.WriteLine("Print sorted array :");

            for (int index = 0; index < arrLeight; index++)
            {
                Console.WriteLine(sortedArrayOfStrings[index]);
            }
        }
    }
}
