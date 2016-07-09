namespace SoftwareAcademy
{
    using System.Text;
    public class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private StringBuilder topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new StringBuilder();
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.StringIsEmpty(value);
                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }

            set
            {
                Validator.ObjeIsNull(value);
                this.teacher = value;
            }
        }

        public string Topics
        {
            get
            {

                return string.Join(", ", this.topics);
            }
        }

        public void AddTopic(string topic)
        {
            this.topics.Append(topic);
        }

        public override string ToString()
        {
            //(course type): Name=(course name); Teacher=(teacher name); 
            //Topics=[(course topics – comma separated)]; 
            //Lab=(lab name – when applicable); Town=(town name – when applicable);
            var output = new StringBuilder();
            output.Append(string.Format("{0}: Name={1}; Teacher={2}; Topics=[{3}]",
                this.GetType().Name,
                this.Name,
                this.Teacher.Name,
                this.Topics));
            return output.ToString();
        }
    }
}
