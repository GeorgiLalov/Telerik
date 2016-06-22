namespace Defining_Classes___Part_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSMCallHistoryTest
    {
        public static void Test()
        {
            Console.WriteLine();
            Console.WriteLine("GSM Call History Test");
            Console.WriteLine();

            const double pricePerMinute = 0.37;
            GSM gsm = new GSM("S4", "Samsung");

            gsm.AddCall(new Call(new DateTime(2016, 9, 6, 13, 05, 11), "0877453624", 135));
            gsm.AddCall(new Call(new DateTime(2016, 9, 6, 04, 33, 56), "+359877453624", 12));
            gsm.AddCall(new Call(new DateTime(2016, 9, 4, 22, 12, 09), "0887453612", 222));

            gsm.DisplayAllCalls();

            double totalPriceOfAllCalls = gsm.GetTotalPriceOfAllCalls(pricePerMinute);
            Console.WriteLine("Total price of all calls : {0}", totalPriceOfAllCalls);

            RemoveLongestCallFromHistory(gsm);
            totalPriceOfAllCalls = gsm.GetTotalPriceOfAllCalls(pricePerMinute);
            Console.WriteLine("Total price without the longest call : {0}", totalPriceOfAllCalls);

            gsm.ClearCallHistory();
            gsm.DisplayAllCalls();
        }

        static void RemoveLongestCallFromHistory(GSM gsm)
        {
            Call longetsCall = new Call(new DateTime(), "", int.MinValue);

            foreach (Call call in gsm.Callhistory)
            {
                if (call.Duration > longetsCall.Duration)
                {
                    longetsCall = call;
                }
            }

            gsm.DeleteCall(longetsCall);
        }
    }
}
