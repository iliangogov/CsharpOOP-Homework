namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Text;
    using Common;
    using Contracts;
    using System.Collections.ObjectModel;

    public class Toothpaste : Product, IToothpaste
    {
        private GenderType gender;
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingrediantes) : base(name, brand, price, gender)
        {
            this.gender = gender;
            this.ingredients = new Collection<string>(ingrediantes);
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ", this.ingredients);
            }
            set
            {
                Validator.CheckIfStringLengthIsValid(value, 12, 4, "Each ingredient must be between 4 and 12 symbols long!");
                this.ingredients.Add(value);
            }

        }

        public override string Print()
        {
            //* Ingredients: {product ingredients, separated by “, “} (when applicable)
            var output = new StringBuilder();
            output.Append(base.Print());
            output.Append(string.Format("  * Ingredients: {0}", this.Ingredients));
            return output.ToString();

        }
    }
}
