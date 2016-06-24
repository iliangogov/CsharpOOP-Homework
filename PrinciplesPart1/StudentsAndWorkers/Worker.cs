namespace StudentsAndWorkers
{
    class Worker:Human
    {
        decimal weekSalary;
        decimal workHoursPerDay;
        decimal moneyPerHour;

        public Worker(string firstname,string lastname,decimal weeksalary,decimal workhoursperday):base(firstname,lastname)
        {
            this.weekSalary = weeksalary;
            this.workHoursPerDay = workhoursperday; 
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = (decimal)value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = (decimal)value;
            }
        }
         public  decimal MoneyPerHour()
        {
            decimal moneyPerHour = 0;
            moneyPerHour = this.weekSalary / this.workHoursPerDay / 5; //assume he works 5 days a week
            return moneyPerHour;
        }
    }
}
