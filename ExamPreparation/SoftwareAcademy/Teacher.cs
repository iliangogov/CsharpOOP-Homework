namespace SoftwareAcademy
{
    using System.Text;
    public class Teacher : ITeacher
    {
        private string name;
        private StringBuilder courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new StringBuilder();
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public string Courses
        {
            get { return string.Join(", ", this.courses); }
            set { this.courses.Append(value); }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Append(course.Name);
        }

        public override string ToString()
        {
            //Teacher: Name=(teacher name); Courses=[(course names – comma separated)]
            var output = new StringBuilder();
            output.Append(string.Format("Teacher: Namee={0}; Courses=[{1}]", this.Name, courses));
            return output.ToString();
        }
    }
}
