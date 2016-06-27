namespace Shapes
{
    using System;

   public class Triangle : Shape
    {
        public Triangle(double width,double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height / 2;
            return surface;
        }
    }
}
