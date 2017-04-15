namespace School
{
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            Discipline math = new Discipline("Maths", 12, 3);
            Discipline english = new Discipline("English", 10, 2);
            Teacher ivanov = new Teacher("Georgi Ivanov");
            Student petkov = new Student("Toshko Petkov");

            ivanov.AddDisciplines(math);
            ivanov.AddDisciplines(english);

            ClassOfStudents clasA = new ClassOfStudents("1A", ivanov);

            //Polymorphism example
            var humans = new List<Human>() { ivanov, petkov };
            humans.ForEach(x => x.Talk());
        }
    }
}
