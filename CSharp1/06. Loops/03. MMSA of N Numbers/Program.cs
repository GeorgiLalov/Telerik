using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MMSA_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double min = Double.MaxValue;
            double max = Double.MinValue;
            double sum = 0;
            double avg = 0;

            for (int i = 1; i <= n; i++)
            {
                double temp = double.Parse(Console.ReadLine());
                if (temp < min)
                    min = temp;
                if (temp > max)
                    max = temp;
                sum += temp;
            }

            avg = sum / n;

            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);

        }
    }
}
