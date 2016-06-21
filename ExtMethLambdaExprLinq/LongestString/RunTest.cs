namespace LongestString
{
    using System;

    class RunTest
    {
        static void Main()
        {
            string[] target = new string[] { "This", "is", "tester" };
            var finder = new LongestStringFinder();
            Console.WriteLine(finder.FindLongestString(target));
        }
    }
}
