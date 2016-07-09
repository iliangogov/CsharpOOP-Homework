using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Engine.Factories;

namespace FurnitureManufacturer.Models
{
    public class Furniture : IFurniture
    {
        //string model, string materialType, decimal price, decimal height
        private string model;
        private string MaterialType;
        private decimal price;
        private decimal height;

        public Furniture(string model,string materialType,decimal price,decimal height)
        {
            this.model = model;
            this.MaterialType = materialType;
            this.price = price;
            this.height = height;
        }
       
        public virtual decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if(value>(decimal)0)
                {
                    this.height = value;
                }
            }
        }

        public string Material
        {
            get
            {
                return this.MaterialType;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            { //•	Model cannot be empty, null or with less than 3 symbols.
                if((!string.IsNullOrEmpty(value))||value.Length>=3)
                {
                    this.model =value;
                }
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
                if (value > 0m)
                {
                    this.price = value;
                }
            }
        }

        public override string ToString()
        {
            string output = string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                this.GetType().Name, this.model, this.MaterialType, this.price, this.height);

            return output;
        }
    }
}
//•	Price cannot be less or equal to $0.00.
//•	Height cannot be less or equal to 0.00 m.
