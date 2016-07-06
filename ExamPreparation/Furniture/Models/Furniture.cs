namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private string materialType;
        private decimal price;
        private decimal height;

        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            if (model == null || model.Length == 0)
            {
                throw new ArgumentException("Model can not be Empty!");
            }

            if (height <= 0)
            {
                throw new ArgumentException("Height must have possitive value!");
            }
            this.model = model;
            this.materialType = materialType;
            this.price = price;
            this.height = height;
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
        }

        public string Material
        {
            get
            {
                return this.materialType;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must have possitive value!");
                }
                this.price = value;
            }
        }
    }
}
