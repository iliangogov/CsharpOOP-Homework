namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, ITable
    {
        private decimal lenght;
        private decimal width;
        private decimal area;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width) : base(model, materialType, price, height)
        {
            this.lenght = length;
            this.width = width;
            this.area = this.lenght * this.width;
        }

        public decimal Area
        {
            get
            {
                return this.area;
            }
        }

        public decimal Length
        {
            get
            {
                return this.lenght;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
        }
    }
}
