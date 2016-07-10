namespace Cosmetics.Products
{
    using System.Text;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IShampoo, IProduct
    {

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {

            this.Milliliters = milliliters;
            this.Usage = usage;

        }

        public uint Milliliters { get; set; }

        public UsageType Usage { get; set; }

        public override string Print()
        {
            //*Quantity: { product quantit} ml(when applicable)
            //* Usage: EveryDay / Medical(when applicable)
            var output = new StringBuilder();
            output.Append(base.Print());
            output.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            output.Append(string.Format("  * Usage: {0}", this.Usage));
            return output.ToString();

        }
    }
}
