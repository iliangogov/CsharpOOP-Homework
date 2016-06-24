namespace School
{
    class Student : Human
    {
        private int classNumber;

        public Student(string name) : base(name)
        {
            this.classNumber = ClassNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }
    }
}
