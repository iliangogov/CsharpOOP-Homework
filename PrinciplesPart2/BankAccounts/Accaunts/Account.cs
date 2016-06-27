namespace BankAccounts
{
    public abstract class Account
    {
        private decimal balance;
        private decimal interestRate;
        private decimal numberOfMonths;
        private Customer customer;

        public Account(Customer customer, decimal balance, decimal interestRate, decimal numberofmonths)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
            this.numberOfMonths = numberofmonths;
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set { }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            protected set { }
        }

        public Customer Customer
        {
            get { return this.customer; }
            protected set { }
        }

        public decimal NumberOfMonths
        {
            get { return this.numberOfMonths; }
            protected set { }
        }

        public virtual decimal CalculateTotalInterest()
        {
            decimal totalInterests = this.numberOfMonths * this.interestRate;
            return totalInterests;
        }
    }
}
