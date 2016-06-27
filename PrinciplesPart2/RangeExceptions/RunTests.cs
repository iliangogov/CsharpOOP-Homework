namespace RangeExceptions
{
    using System;

    class RunTests
    {
        static void Main()
        {
            try
            {
                int begin = 1;
                int last = 100;

                int number = 150;

                if (begin < number && number > last)
                    throw new InvalidRangeException<int>(begin, last);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Begin: {0}, Last: {1}", ex.Begin, ex.Last);
            }

            Console.WriteLine();

            try
            {
                DateTime begin = new DateTime(1980, 1, 1);
                DateTime last = new DateTime(2013, 12, 31);

                DateTime date = new DateTime(2014, 2, 1);

                if (begin < date && date > last)
                    throw new InvalidRangeException<DateTime>(begin, last);
            }
            catch (InvalidRangeException<DateTime> z)
            {
                Console.WriteLine(z.Message);
                Console.WriteLine("Begin: {0}, Last: {1}", z.Begin, z.Last);
            }
        }
    }
}
