namespace BankAccounts
{
    public class Customer
    {
        public Account Account { get; set; }
        public string Name { get; set; }
        public Type Type { get; set; }

        public Customer()
        {

        }

        public Customer(string name, Account account, Type type)
        {
            this.Name = name;
            this.Account = account;
            this.Type = type;
        }

    }
}
