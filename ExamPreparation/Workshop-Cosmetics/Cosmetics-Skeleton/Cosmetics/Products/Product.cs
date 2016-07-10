namespace Cosmetics.Products
{
    using Common;
    using Contracts;
    using System.Text;

    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }
        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, 10, 2, "Product brand must be between 2 and 10 symbols long!");
                this.brand = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, 10, 3, "Product name must be between 3 and 10 symbols long!");
                this.name = value;
            }
        }
        public decimal Price
        {
            get
            {
                Shampoo s = this as Shampoo;

                if (s != null)
                {
                    return s.price * s.Milliliters;
                }
                else
                {
                    return this.price;
                }
            }
            set
            {
                this.price = value;
            }
        }

        public virtual string Print()
        {
            //- { product brand} – { product name}:
            // *Price: ${ product price}
            // *For gender: Men / Women / Unisex

            var output = new StringBuilder();
            output.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            output.AppendLine(string.Format("  * Price: ${0}", this.Price));
            output.AppendLine(string.Format("  * For gender: {0}", this.Gender));

            return output.ToString();
        }
    }
}
