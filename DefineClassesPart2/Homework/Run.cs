namespace Homework
{
    using System;
   
    class Run
    {
        static void Main()
        {
            var point = new Point3D(1, 2, 3);           //test point3d instance
            var secondpoint = new Point3D(4, 5, 6);
            var thirdpoint = new Point3D(7, 8, 9);

            Console.WriteLine(point.ToString());        //test ToString()
            Console.WriteLine(secondpoint.ToString());
            Console.WriteLine(Point3D.StartPoint.ToString());   //test StartPoint

            Console.WriteLine("Distance:{0}\n", CalculateDistance.GetDistance(point, secondpoint));   //test distance

            var path = new Path();    //test Path
            path.AddPoint(point);
            path.AddPoint(secondpoint);
            path.AddPoint(thirdpoint);
            Console.WriteLine(path.DisplayPath());

            path = PathStorage.Load("../../input.txt");   //test PathSorage
            Console.WriteLine("\nPoints in path (total: {0})\n{1}", path.Count, path);

            var list = new GenericList<int>();            //test GenericList -works with another datatypes as well!
            list.Add(5);
            list.Add(6);                                       // Add
            Console.WriteLine(list.Access(0));                 // Access
            Console.WriteLine(list.Access(1));
            list.InsertAt(7, 0);                               // Insert
            Console.WriteLine(list.Access(0));
            Console.WriteLine(list.Access(1));
            Console.WriteLine(list.Access(2));
            Console.WriteLine(list.FindByValue(6));            // FindByValue


            Console.WriteLine(list.Min());                     // MIn
            Console.WriteLine(list.Max());                     // Max

            list.Clear();                                      // Clear
            
            var matrix = new Matrix<int>(2,2);              // Test Matrix
            var secondMatrix = new Matrix<int>(2, 2);
            matrix[0, 0] = 2;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 3;
            secondMatrix[0, 0] = 4;
            secondMatrix[0, 1] = 4;
            secondMatrix[1, 0] = 5;
            secondMatrix[1, 1] = 5;
            Console.WriteLine(matrix);
            Console.WriteLine(secondMatrix);
            Console.WriteLine(matrix * secondMatrix);
           
        }
    }
}
