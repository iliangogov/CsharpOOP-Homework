namespace School
{
    public class Discipline : Icommentable
    {
        private string name;
        private int lections;
        private int exercises;
        private string comment;

        public Discipline(string name, int lections, int exercises)
        {
            this.name = name;
            this.lections = lections;
            this.exercises = exercises;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Lections
        {
            get { return this.lections; }
            set { this.lections = value; }
        }

        public int Exercises
        {
            get { return this.exercises; }
            set { this.exercises = value; }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {

            }
        }
    }
}
