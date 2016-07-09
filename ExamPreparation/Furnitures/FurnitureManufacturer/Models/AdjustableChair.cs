using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class AdjustableChair : Chair,IAdjustableChair
    {
        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs) : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public override decimal Height
        {
            get
            {
                return base.Height;
            }

            set
            {
                if (value > 0)
                {
                    base.Height = value;
                }
            }
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
