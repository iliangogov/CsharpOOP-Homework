using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod.Students
{
    public class ClassOfStudents : IEnumerable
    {
        private List<Student> classOfStudents;

        public ClassOfStudents()
        {
            this.classOfStudents = new List<Student>();
        }


        public void AddStudent(Student student)
        {
            this.classOfStudents.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.classOfStudents.Remove(student);
        }

        public string FirstBeforeLast()
        {
            string eachStudent = "";
            var output =
                from Student student in this.classOfStudents
                where string.Compare(student.FirstName, student.LastName) < 1
                select student;
            foreach (var student in output)
            {
                eachStudent += student.ToString() + "\n";
            }
            return eachStudent;

        }

        public string AgeRange()
        {
            string eachStudent = "";
            var output =
                from Student student in this.classOfStudents
                where (student.Age >= 18 && student.Age <= 24)
                select student.FirstName + " " + student.LastName;
            foreach (var student in output)
            {
                eachStudent += student.ToString() + "\n";
            }
            return eachStudent;

        }

        public string SortByNameDescendingLinq() 
        {
            string output = "";
            var ordered = this.classOfStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            foreach (var s in ordered)
            {
                output += s.ToString();
            }
            return output;

        }

        public string SortByNameDescending()       //OrderBy ThanBy Extension method with Lambda
        {
            string output = "";
            var ordered = from s in this.classOfStudents
                          orderby s.FirstName descending,
                                  s.LastName descending
                          select s;

            foreach (var s in ordered)
            {
                output += s.ToString();
            }
            return output;
        }

        public string GroupByGroupNumber()
        {
            string output = "";
            var ordered = this.classOfStudents.OrderBy(x => x.Group);
            foreach (var s in ordered)
            {
                output += s.ToString();
            }
            return output;
        }
        
        public IEnumerator GetEnumerator()
        {
            return this.classOfStudents.GetEnumerator();
        }


    }
}
