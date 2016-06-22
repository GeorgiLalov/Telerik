namespace Defining_Classes___Part_2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    static class PathStorage
    {
        static string filePath = "../../file.txt";

        /** File Format :
         *  number of points
         *  x y z
         */ 

        public static Point3D[] LoadPaths()
        {
            int index = 0;
            Point3D[] points = null;
            string line;
            var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                while( ( line = streamReader.ReadLine() ) != null)
                {
                    if (points == null)
                    {
                        points = new Point3D[int.Parse(line)]; // initialize points[] if not, the first line
                    }
                    else
                    {
                        int[] coordinates = line.Split(' ').Select(int.Parse).ToArray(); // split coordinates

                        points[index] = new Point3D(coordinates[0], coordinates[1], coordinates[2]);
                        index++;
                    }
                }
            }

            return points;
        }

        public static void SavePaths(Point3D[] points)
        {
            var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            using (var streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
            {
                streamWriter.WriteLine(points.Length); // on first line write number of points

                foreach (Point3D point in points)
                {
                    streamWriter.WriteLine("{0} {1} {2}", point.X, point.Y, point.Z);
                }
            }
        }
    }
}
