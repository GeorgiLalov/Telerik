using System;

namespace _5.Conductors
{
    class Program
    {
        static void Main(string[] args)
        {
            uint perforator = uint.Parse(Console.ReadLine());
            int countNumbers = int.Parse(Console.ReadLine());
            uint mask = 0;

            for (int counter = 0; counter < countNumbers; counter++)
            {
                uint ticket = uint.Parse(Console.ReadLine());
                mask = 0;

                for (int shift = 0; ticket >= mask; shift++)
                {
                    mask = (perforator << shift);

                    if ((ticket & mask) == mask)
                    {
                        ticket ^= mask;
                    }

                }

                Console.WriteLine(ticket);
            }
        }
    }
}
