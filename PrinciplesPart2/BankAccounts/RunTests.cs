namespace BankAccounts
{
    using System;

    class RunTests
    {
        static void Main()
        {
            var Ivan = new Customer();
            var dep = new Deposit(Ivan, 1500, 1.2m, 12);
            Ivan.Account = dep;
            Console.WriteLine(Ivan.Account.CalculateTotalInterest());

        }
    }
}
