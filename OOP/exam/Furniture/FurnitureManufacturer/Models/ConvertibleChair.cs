namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const decimal covertedHeight = 0.10M;
        private readonly decimal initialHeight;
        private bool isConverted;
        public ConvertibleChair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.IsConverted = false;
            this.initialHeight = this.Height;
        }
        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
            private set
            {
                this.isConverted = value;
            }

        }

        public void Convert()
        {
            if (!IsConverted)
            {
                this.IsConverted = !this.IsConverted;
                this.Height = covertedHeight;
            }
            else
            {
                this.IsConverted = !this.IsConverted;
                this.Height = initialHeight;
            }
        }
    }
}
