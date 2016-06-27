namespace BankAccounts
{
    public class Loan : Account, IDeposit
    {
        private const decimal IndividualNoInterestMonths = 3;
        private const decimal CompanyNoInterestMonths = 2;

        public Loan(Customer customer, decimal balance, decimal interestRate, decimal numberofmonths) : base(customer, balance, interestRate, numberofmonths)
        {
        }

        public override decimal CalculateTotalInterest()
        {
            decimal totalInterests = 0;
            if (this.Customer.Type.Equals(Type.companies))
            {
                if (this.NumberOfMonths < CompanyNoInterestMonths)
                {
                    totalInterests = 0;
                }
                else
                {
                    totalInterests = (this.NumberOfMonths - CompanyNoInterestMonths) * this.InterestRate;
                }
            }
            else
            {
                if (this.NumberOfMonths < IndividualNoInterestMonths)
                {
                    totalInterests = 0;
                }
                else
                {
                    totalInterests = (this.NumberOfMonths - IndividualNoInterestMonths) * this.InterestRate;
                }
            }
            return totalInterests;
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
