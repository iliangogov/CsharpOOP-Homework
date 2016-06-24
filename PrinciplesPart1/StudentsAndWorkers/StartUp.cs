namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).

            List<Student> students = new List<Student>();
            #region generate new students and add them in the list

            var ivan = new Student("Ivan", "Ivanov", 8);
            var pesho = new Student("Petar", "Petrov", 7);
            var kiril = new Student("Kiril", "Kirilov", 6);
            var zahari = new Student("Zahari", "Zahariev", 9);
            var evgeni = new Student("Evgeni", "Evgeniev", 10);
            var gosho = new Student("Georgi", "Georgiev", 11);
            var stanko = new Student("Stanko", "Stankov", 5);
            var ivo = new Student("Ivo", "Ivkov", 4);
            var stefan = new Student("Stefan", "Stefanov", 3);
            var toni = new Student("Anton", "Antonov", 2);
            students.Add(ivan);
            students.Add(pesho);
            students.Add(kiril);
            students.Add(zahari);
            students.Add(evgeni);
            students.Add(gosho);
            students.Add(stanko);
            students.Add(ivo);
            students.Add(stefan);
            students.Add(toni);

            #endregion

            var sortedStudents = students.OrderBy(x => x.Grade).ToList();

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Grade);
            }
            Console.WriteLine("=======================================");
            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>();
            #region generate new students and add them in the list

            var fiki   =new Worker("Fikret", "Fikretov",300,8);
            var abi  =new Worker("Abdul", "Abdulov",250,6);
            var gencho  =new Worker("Gencho", "Genchev",180, 6);
            var bugi =new Worker("Bugi", "Barabov",450, 9);
            var ceco =new Worker("Cvetan", "Cvetanov",360, 10);
            var velik  =new Worker("Velik", "Velikov",270, 11);
            var gibi =new Worker("Gibon", "Gibonov",500, 5);
            var djeki    =new Worker("Djeki", "Djekov",160, 4);
            var puhi =new Worker("Asparuh", "Asparuhov",140, 3);
            var toncho = new Worker("Toncho", "Tokmakchiev", 200, 8);
               
            workers.Add(fiki);
            workers.Add(abi);
            workers.Add(gencho);
            workers.Add(bugi);
            workers.Add(ceco);
            workers.Add(velik);
            workers.Add(gibi);
            workers.Add(djeki);
            workers.Add(puhi);
            workers.Add(toncho);

            #endregion
            var sortedWorkers =
               ( from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker).ToList();

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0} {1} {2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
            Console.WriteLine("=======================================");
            //Merge the lists and sort them by first name and last name.
            var mergedList = new List<Human>();

            mergedList.AddRange(students);
            mergedList.AddRange(workers);
            var sortedMergedList =
                (from human in mergedList
                 orderby human.FirstName
                 orderby human.LastName
                 select human).ToList();
            foreach (var human in sortedMergedList)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
        }
    }
}
