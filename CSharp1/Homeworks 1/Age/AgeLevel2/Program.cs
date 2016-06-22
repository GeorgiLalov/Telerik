using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeLevel2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime yourBirhtday = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
            DateTime currentDate = DateTime.Now;
            int yourAge = (int) ((currentDate.Date - yourBirhtday.Date).TotalDays / 365.25);
            Console.WriteLine("{0}\n{1}", yourAge, yourAge + 10 );
        }
    }
}
