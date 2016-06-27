using System;

namespace Shapes
{
    class Sqare : Shape
    {
        public Sqare(double width)
        {
            this.Width = width;
            this.Height = width;
        }

        public double Width { get; set; }
        public double Height { get; private set; }
        

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Width;
            return surface;
        }
    }
}
