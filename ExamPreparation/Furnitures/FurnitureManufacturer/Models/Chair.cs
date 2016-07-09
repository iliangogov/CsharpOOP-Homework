using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Chair : Furniture,IChair
    {
        private int numberOfLegs;

        public Chair(string model, string materialType, decimal price, decimal height,int numberOfLegs) 
            : base(model, materialType, price, height)
        {
            this.numberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
        }

        public override decimal Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                base.Height = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Legs: {0}", this.numberOfLegs);
        }
    }
}
