namespace School
{
    public abstract class Human : Icommentable
    {
        private string name;
        private string comment;

        protected Human(string name)
        {
            this.name = name;
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

        public abstract void Talk();
    }
}
