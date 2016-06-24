namespace School
{
    using System.Collections.Generic;

    public class ClassOfStudents : Icommentable
    {
        private List<Teacher> setOfTeachers;
        private string textIdentifier;
        private string comment;

        public ClassOfStudents(string textIdentifier, Teacher teacher)
        {
            this.textIdentifier = textIdentifier;
            this.setOfTeachers = new List<Teacher>();
            this.setOfTeachers.Add(teacher);
        }

        public List<Teacher> SetOfTeachers
        {
            get { return this.setOfTeachers; }
            set
            {
                this.setOfTeachers = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.setOfTeachers.Add(teacher);
        }

    }
}
