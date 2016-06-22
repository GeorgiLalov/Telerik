using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.Bunny_Factory
{
    class Program
    {
        static List<BigInteger> CreateCagesList(string cagesString)
        {
            List<BigInteger> cagesList = new List<BigInteger>();

            foreach (char letter in cagesString)
            {
                BigInteger number = (BigInteger)letter - 48;

                if (number > 1)
                {
                    cagesList.Add(number);
                }
            }

            return cagesList;
        }

        static List<BigInteger> Cycle(List<BigInteger> cagesList)
        {
            for (int indexOfCycle = 1; indexOfCycle <= cagesList.Count; indexOfCycle++)
            {
                BigInteger sumNextSCages = 0;
                int indexOfCage = 0;

                // calc sumNextSCages
                for (indexOfCage = 0; indexOfCage < indexOfCycle; indexOfCage++)
                {
                    sumNextSCages += cagesList[indexOfCage];
                }

                if (sumNextSCages > (BigInteger)(cagesList.Count - indexOfCage))
                {
                    break;
                }

                BigInteger sumOfBunnies = 0, productOfBunnies = 1;
                // from current index to sumIndex calc sum and product of bunnies
                for (; (BigInteger)indexOfCage < sumNextSCages + (BigInteger)indexOfCycle; indexOfCage++)
                {
                    sumOfBunnies += cagesList[indexOfCage];
                    productOfBunnies *= cagesList[indexOfCage];
                }

                StringBuilder appendCages = new StringBuilder();
                appendCages.Append(sumOfBunnies.ToString());
                appendCages.Append(productOfBunnies.ToString());

                for (; indexOfCage < cagesList.Count; indexOfCage++)
                {
                    appendCages.Append(cagesList[indexOfCage].ToString());
                }

                cagesList = CreateCagesList(appendCages.ToString());
            }

            return cagesList;
        }

        static void Main(string[] args)
        {
            List<BigInteger> cagesList = new List<BigInteger>();
            string input = null;

            while ((input = Console.ReadLine()) != "END")
            {
                cagesList.Add(BigInteger.Parse(input));
            }

            //cycle

            cagesList = Cycle(cagesList);

            foreach (BigInteger number in cagesList)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
