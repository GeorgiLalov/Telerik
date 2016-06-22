namespace Defining_Classes___Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSMTest
    {

        public static void Test()
        {
            Console.WriteLine("GSM Test");
            Console.WriteLine();

            GSM[] arrOfGSMs = 
            {
                new GSM("S6", "Samsung", 700, "Pesho", new Battery("BAT", 200, 100, BatteryType.LiIon), new Display(7, 2000000)),
                new GSM("5S", "Apple", 1200, "Gosho", new Battery("MM", 3050, 250), new Display()),
                new GSM("S5", "Samsung")
            };

            foreach (GSM gsm in arrOfGSMs)
            {
                Console.WriteLine(gsm.ToString());
            }

            Console.WriteLine(GSM.IPhone4S.ToString());

        }

    }
}
