namespace _02.Enter_numbers
{
    using System;

    class StartUp
    {
        static int ReadNumber(int start, int end)
        {
            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
                if (number <= start || number >= end)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                throw new FormatException();
            }

            return number;
        }

        static void Main(string[] args)
        {
            int minStart = 1;
            int maxStart = 100;
            int maxCount = 10;
            int[] array = new int[maxCount];

            try
            {

                for (int count = 0; count < maxCount; count++)
                {
                    if (count != 0)
                    {
                        minStart = array[count - 1];
                    }


                    array[count] = ReadNumber(minStart, maxStart);

                }

                Console.WriteLine("1 < " + string.Join(" < ", array) + " < 100");

            }
            catch (FormatException)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
