using System;

namespace _2.Speeds
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            int sumMaxGroupSpeed = 0;
            int currentSumOfSpeed = 0;
            int maxGroupLeight = 0;
            int currentGroupLeight = 0;
            int previousSpeed = 0;

            for (int countCars = 0; countCars < numOfCars; countCars++)
            {
                int currentSpeed = int.Parse(Console.ReadLine());
                if (countCars == 0 || currentSpeed <= previousSpeed)
                {
                    previousSpeed = currentSpeed;
                    currentSumOfSpeed = currentSpeed;
                    currentGroupLeight = 1;
                    if (countCars == 0)
                        sumMaxGroupSpeed = currentSumOfSpeed;
                }
                else if (currentSpeed > previousSpeed)
                {
                    currentGroupLeight++;
                    currentSumOfSpeed += currentSpeed;
                    if (currentGroupLeight > maxGroupLeight)
                    {
                        maxGroupLeight = currentGroupLeight;
                        sumMaxGroupSpeed = currentSumOfSpeed;
                    }
                    else if (currentGroupLeight == maxGroupLeight && currentSumOfSpeed > sumMaxGroupSpeed)
                    {
                        sumMaxGroupSpeed = currentSumOfSpeed;
                    }
                }
            }

            Console.WriteLine(sumMaxGroupSpeed);

        }
    }
}
