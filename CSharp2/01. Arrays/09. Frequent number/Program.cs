using System;
using System.Collections.Generic;


namespace _09.Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeight = int.Parse(Console.ReadLine());
            int[] array = new int[arrLeight];
            short[] arrayCountRepeatTimes = new short[10001];
            int maxNumber = 0;
            int countMaxRepeatTime = 0;
            int repeatingNumber = 0;

            for (int index = 0; index < arrLeight; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
                arrayCountRepeatTimes[array[index]]++;
                if (array[index] > maxNumber)
                {
                    maxNumber = array[index];
                }
            }

            for (int index = 0; index <= maxNumber; index++)
            {
                if (arrayCountRepeatTimes[index] > countMaxRepeatTime)
                {
                    countMaxRepeatTime = arrayCountRepeatTimes[index];
                    repeatingNumber = index;
                }
            }

            Console.WriteLine("{0} ({1} times)", repeatingNumber, countMaxRepeatTime);
        }
    }
}
