namespace Cosmetics.Cart
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Common;
    using Contracts;
    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> productList;

        public ShoppingCart()
        {
            this.ProductList = new Collection<IProduct>();
        }

        public ICollection<IProduct> ProductList
        {
            get { return this.productList; }
            set
            {
                Validator.CheckIfNull(value);
                this.productList = value;

            }
        }

        public void AddProduct(IProduct product)
        {
            this.productList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.productList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (this.productList.Contains(product))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal TotalPrice()
        {
            decimal total = 0m;
            foreach (var item in productList)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
