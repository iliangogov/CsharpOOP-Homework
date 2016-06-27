namespace BankAccounts
{
    public class Mortgage : Account, IDeposit
    {
        private const decimal IndividualNoInterestMonths = 6;
        private const decimal CompanyNoInterestMonths = 12;

        public Mortgage(Customer customer, decimal balance, decimal interestRate, decimal numberofmonths) : base(customer, balance, interestRate, numberofmonths)
        {
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateTotalInterest()
        {
            decimal totalInterests = 0;
            if (this.Customer.Type.Equals(Type.companies))
            {
                if (this.NumberOfMonths < CompanyNoInterestMonths)
                {
                    totalInterests = (this.NumberOfMonths * this.InterestRate) / 2;
                }
                else
                {
                    totalInterests = (CompanyNoInterestMonths * this.InterestRate) / 2 +
                        (this.NumberOfMonths - CompanyNoInterestMonths * this.InterestRate);
                }
            }
            else
            {
                if (this.NumberOfMonths < IndividualNoInterestMonths)
                {
                    totalInterests = (this.NumberOfMonths * this.InterestRate) / 2;
                }
                else
                {
                    totalInterests = (IndividualNoInterestMonths * this.InterestRate) / 2 +
                        (this.NumberOfMonths - IndividualNoInterestMonths * this.InterestRate);
                }
            }
            return totalInterests;
        }
    }
}
