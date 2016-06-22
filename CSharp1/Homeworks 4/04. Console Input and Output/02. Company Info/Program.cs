using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Company_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddresss = Console.ReadLine();
            string tel = Console.ReadLine();
            string fax = Console.ReadLine();
            string webSite = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string telName = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddresss);
            Console.WriteLine("Tel. {0}" ,tel);
            if(fax.Length == 0)
                Console.WriteLine("Fax: (no fax)");
            else
                Console.WriteLine("Fax: {0}", fax);
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, telName);
        }
    }
}
