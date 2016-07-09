using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair,IConvertibleChair
    {
        private decimal initialHeight;
        private bool isConverted;
        

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs) : base(model, materialType, price, height, numberOfLegs)
        {
            this.initialHeight = height;
            this.isConverted = false;
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
        }

        public void Convert()
        {
            if (isConverted == false)
            {
                this.initialHeight = base.Height;
                base.Height = 0.10m;
                isConverted = true;
            }
            else
            {
                base.Height = this.initialHeight;
                isConverted = false;
            }
           
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
