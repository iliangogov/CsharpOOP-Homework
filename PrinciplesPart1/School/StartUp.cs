namespace School
{
    using System;

    class StartUp
    {
        static void Main()
        {
            Discipline math = new Discipline("Maths", 12, 3);
            Discipline english = new Discipline("English", 10, 2);
            Teacher ivanov = new Teacher("Georgi Ivanov");
            ivanov.AddDisciplines(math);
            ivanov.AddDisciplines(english);
            ClassOfStudents clasA = new ClassOfStudents("1A", ivanov);
           
        }
    }
}
