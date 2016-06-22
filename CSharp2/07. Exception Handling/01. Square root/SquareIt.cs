namespace _01.Square_root
{
    using System;

    class SquareIt
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine("{0:F3}", Math.Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
