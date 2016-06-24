namespace StudentsAndWorkers
{
   public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstname,string lastname)
        {
            this.firstName = firstname;
            this.lastName = lastname;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
