using System;

namespace _72RefEnhancements
{
    class ReadonlyStruct
    {
        public static void Run()
        {
            var p1 = new Point3D(0, 0, 0);
            var p2 = new Point3D(10, 10, 10);

            var dist = Distance(p1, p2);

            Console.WriteLine($"Distance between points is: {dist}");
        }

        static double Distance(in Point3D p1, in Point3D p2)
        {
            //p1 = p2;

            double deltaX = p1.X - p2.X;
            double deltaY = p1.Y - p2.Y;
            double deltaZ = p1.Z - p2.Z;

            double distance =  Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            return distance;
        }
    }

    readonly struct Point3D
    {
        public readonly double X;
        public readonly double Y;
        public readonly double Z;

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
