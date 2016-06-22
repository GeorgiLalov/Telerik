using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{
    class Program
    {
        static void Main(string[] args)
        {
            double firtsSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double thirdSide = double.Parse(Console.ReadLine());

            double p = (firtsSide + secondSide + thirdSide) / 2.0;
            double surface = Math.Sqrt( p * (p - firtsSide) * (p - secondSide) * (p - thirdSide) );

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
