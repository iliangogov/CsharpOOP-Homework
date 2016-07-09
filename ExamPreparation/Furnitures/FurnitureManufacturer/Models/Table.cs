using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Table : Furniture,ITable
    {
        //decimal length, decimal width
        private decimal length;
        private decimal width;

        public Table(string model, string materialType, decimal price, decimal height,decimal length,decimal width) 
            : base(model, materialType, price, height)
        {
            this.length = length;
            this.width = width;
        }

        public decimal Area
        {
            get
            {
                return this.width*this.length;
            }
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Length: {0}, Width: {1}, Area: {2}", this.length,this.width,this.Area);
        }
    }
}
