namespace Homework
{
    [Version(2,11)]
    public struct Point3D 
    {
        private static readonly Point3D startPoint = new Point3D(0d, 0d, 0d);   //task 2

        public Point3D(double X, double Y, double Z)   // task 1
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;                                  
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartPoint      //task 2
        {
            get { return Point3D.startPoint; }
        }

        public override string ToString()  //task 1
        {
            return string.Format("***This Point has the following coordinates***\nX={0}, Y={1}, Z={2}\n"
                                   , this.X, this.Y, this.Z);
        }
    }
}
