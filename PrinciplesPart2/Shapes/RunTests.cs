namespace Shapes
{
    using System;

    class RunTests
    {
        static void Main()
        {
            var triang = new Triangle(3, 4);
            var rectang = new Rectangle(4, 5);
            var sqare = new Sqare(3);

            var array = new Shape[3];
            array[0] = triang;
            array[1] = rectang;
            array[2] = sqare;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(array[i].CalculateSurface());
            }


        }
    }
}
