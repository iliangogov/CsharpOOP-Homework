namespace Homework
{
    using System;

    public static class CalculateDistance
    {
        public static double GetDistance(Point3D firstpoint, Point3D secondpoint)   //task 3
        {
            double x1 = firstpoint.X;
            double y1 = firstpoint.Y;
            double z1 = firstpoint.Z;
            double x2 = secondpoint.X;
            double y2 = secondpoint.Y;
            double z2 = secondpoint.Z;
            double distance = Math.Sqrt(
                ((x2 - x1) * (x2 - x1)) +
                ((y2 - y1) * (y2 - y1)) +
                ((z2 - z1) * (z2 - z1))                      // math formula from web!
                );
            return distance;
        }
    }
}
