namespace Homework
{
    using System;
    using System.Collections.Generic;

    public class Path           //task 4
    {
        private List<Point3D> path;


        public Path()
        {
            this.path = new List<Point3D>();
        }

        public int Count
        {
            get
            {
                return this.path.Count;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.path.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            if (path.Contains(point))
            {
                this.path.Remove(point);
            }
            else
            {
                throw new ArgumentException("There is no such a Point in this Path");
            }
        }

        public Path Clear()
        {
            this.path.Clear();

            return this;
        }

        public string DisplayPath()
        {
            string output="This Path contains the following points:\n";
            int index = 1;
            foreach (var point in path)
            {
                output+=string.Format("\nPoint({0})-coordinates: X={1},Y={2},Z={3}",index,point.X,point.Y,point.Z);
                index++;
            }
            return output;
        }
    }
}
