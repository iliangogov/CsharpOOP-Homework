namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;

    public class AdjustableChair : Chair, IChair, IAdjustableChair
    {
        private decimal height;
        private int numberOfLegs;

        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs) : base(model, materialType, price, height, numberOfLegs)
        {
            this.numberOfLegs = numberOfLegs;
        }

        public void SetHeight(decimal height)
        {
            if (height <= 0)
            {
                throw new ArgumentException("Height must have possitive value!");
            }
            this.height = height;
        }
    }
}
