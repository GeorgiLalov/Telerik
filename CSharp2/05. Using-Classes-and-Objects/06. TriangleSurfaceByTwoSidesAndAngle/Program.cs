using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriangleSurfaceByTwoSidesAndAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            double firtsSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());

            //  convert degrees to radians
            angle *= (Math.PI / 180.0);

            double surface = (firtsSide * secondSide * Math.Sin(angle)) / 2.0;

            Console.WriteLine("{0:F2}", surface);
        }
    }
}
