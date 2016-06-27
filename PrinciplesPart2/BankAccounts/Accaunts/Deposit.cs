namespace BankAccounts
{
    public class Deposit : Account, IDeposit, IWithDraw
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate, decimal numberofmonths)
            : base(customer, balance, interestRate, numberofmonths)
        {
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
            }
        }

        void IDeposit.Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateTotalInterest()
        {
            decimal totalInterests = 0;
            if (this.Balance < 0 || this.Balance > 1000)
            {
                totalInterests = this.NumberOfMonths * this.InterestRate;
            }
            return totalInterests;
        }
    }
}
