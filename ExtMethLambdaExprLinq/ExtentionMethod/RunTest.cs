namespace ExtentionMethod
{
    using System;
    using System.Text;
    using Students;
   
    class RunTest
    {
        static void Main()
        {
            //test StrinBuilder Extention   //problem1
            var test = new StringBuilder();
            test.Append("Vacation is comming!");
            Console.WriteLine("test StringBuilder=> " + test);
            Console.WriteLine("Substring out of-*test* from index 0 and length 8 is: " + test.Substring(0, 8) + "\n"); // "Vacation" is shown

            //test IenumerableExtantions //problem2
            var test2 = new int[3];
            test2[0] = 1;
            test2[1] = 2;
            test2[2] = 21;
            Console.WriteLine("Sum of this collection is: " + IEnumerableExtantions.Sum(test2));
            Console.WriteLine("Max ellement of this collection is: " + IEnumerableExtantions.Max(test2) + "\n");
            Console.WriteLine("Ellement divisible by 3 and 7 of this collection is:");   //problem6
            IEnumerableExtantions.numsInArrayDivisBy3and7(test2);
            IEnumerableExtantions.numsInArrayDivisBy3and7LAMBDA(test2);
            // test Student, ClassOfStudents
            var ceco = new Student("Tsvetan", "Angov","ceco@gmail.com","0888123456",2,24);
            var ivancho = new Student("Ivan", "Ivanov", "ivancho@gmail.com", "0888333333", 1, 20);
            var studentClass = new ClassOfStudents();
            studentClass.AddStudent(ceco);
            studentClass.AddStudent(ivancho);
            Console.WriteLine("//Students with First name before lastname alphabeticaly:\n"+studentClass.FirstBeforeLast());   //problem3
            Console.WriteLine("//by AgeInRange 18-24:\n"+studentClass.AgeRange());          //problem4
            Console.WriteLine("//StudentClass sort by name descending:\n"+ studentClass.SortByNameDescending()); // problem5
            Console.WriteLine("//Students ordered by GroupNumber:\n"+studentClass.GroupByGroupNumber());
        }
    }
}
