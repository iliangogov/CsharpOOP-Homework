namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IChair, IConvertibleChair
    {
        private bool isConverted = false;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs) : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
        }

        public new decimal Height
        {
            get { return this.Height; }
            private set { }
        }

        public void Convert()
        {
            this.Height = 0.1m;
        }
    }
}
