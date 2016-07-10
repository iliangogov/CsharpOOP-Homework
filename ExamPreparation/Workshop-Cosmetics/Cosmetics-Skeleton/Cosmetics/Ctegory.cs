namespace Cosmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Common;
    using Contracts;
    public class Category : ICategory
    {
        private const int CategoryMinLength = 2;
        private const int CategoryMaxLength = 15;
        private string name;
        private ICollection<IProduct> productList;

        public Category(string name)
        {
            this.Name = name;
            this.productList = new List<IProduct>();
        }

        public ICollection<IProduct> ProductList
        {
            get { return new List<IProduct>(this.productList); }
            set { this.productList = value; }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringLengthIsValid(
                    value,
                    CategoryMaxLength,
                    CategoryMinLength,
                    String.Format(GlobalErrorMessages.InvalidStringLength, this.GetType().Name
                    + " name", CategoryMinLength, CategoryMaxLength));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics);
            this.productList.Add(cosmetics);
        }

        public string Print()
        {
            var output = new StringBuilder();
            output.Append(string.Format("{0} category - {1} {2} in total",
                this.Name,
                productList.Count,
                productList.Count == 1
                ? "product"
                : "products"));

            var newList = this.ProductList.OrderBy(x => x.Brand).ThenByDescending(x => x.Price);

            foreach (var product in newList)
            {
                output.AppendLine();
                output.Append(product.Print());
            }
            return output.ToString();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            this.productList.Remove(cosmetics);
        }
    }
}
