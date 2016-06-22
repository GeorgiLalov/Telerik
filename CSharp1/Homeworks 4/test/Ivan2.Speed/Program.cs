using System;

namespace speed
{
    class Program
    {
        static void Main(string[] args)
        {

            int br_Avtobusi = int.Parse(Console.ReadLine());
            int Avtobus = 0;
            int speed_grup_moment = 0;
            int count_Avtobusi_moment = 1;
            int count_Avtobusi_max = 0;
            int big_Speed_Ever = 0;

            for (int i = 1; i <= br_Avtobusi; i++)
            { // OK

                int Momenten_Avtobus = int.Parse(Console.ReadLine()); // OK
                if (i == 1)
                {
                    Avtobus = Momenten_Avtobus;
                }

                // проверка за скоростите и инициализиране на big_Speed_Ever

                if (Momenten_Avtobus > Avtobus)
                {
                    count_Avtobusi_moment++; // OK
                    speed_grup_moment = speed_grup_moment + Momenten_Avtobus; // OK
                    
                    if (count_Avtobusi_moment > count_Avtobusi_max)
                    {
                        count_Avtobusi_max = count_Avtobusi_moment;
                        big_Speed_Ever = speed_grup_moment;
                    }
                    else if(count_Avtobusi_moment == count_Avtobusi_max)
                    {
                        if (speed_grup_moment > big_Speed_Ever)
                        {
                            big_Speed_Ever = speed_grup_moment;
                        }
                    }

                    continue;
                }
                

                if (Momenten_Avtobus <= Avtobus)
                {
                    Avtobus = Momenten_Avtobus;
                    count_Avtobusi_moment = 1;
                    speed_grup_moment = Momenten_Avtobus;

                    if (count_Avtobusi_moment > count_Avtobusi_max)
                    {
                        count_Avtobusi_max = count_Avtobusi_moment;
                        big_Speed_Ever = speed_grup_moment;
                    }
                    else if (count_Avtobusi_moment == count_Avtobusi_max)
                    {
                        if (speed_grup_moment > big_Speed_Ever)
                        {
                            big_Speed_Ever = speed_grup_moment;
                        }
                    }
                }


            }
            Console.WriteLine(big_Speed_Ever);
        }

    }
}