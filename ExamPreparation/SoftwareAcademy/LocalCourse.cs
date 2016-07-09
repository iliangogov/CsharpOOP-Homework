namespace SoftwareAcademy
{
    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;
        public LocalCourse(string name, ITeacher teacher, string lab) : base(name, teacher)
        {
            this.Lab = lab;
        }
        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                Validator.StringIsEmpty(value);
                this.lab = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("; Lab={0}", this.lab);
        }
    }
}
