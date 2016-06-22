namespace Defining_Classes___Part_2
{
    class Path
    {
        public Point3D[] Points3D { get; set; }

        public Path(Point3D[] points3D)
        {
            this.Points3D = points3D;
        }
    }
}
