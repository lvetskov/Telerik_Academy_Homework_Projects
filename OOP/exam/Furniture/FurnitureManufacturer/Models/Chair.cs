namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Chair : Furniture, IChair
    {
        protected int numberOfLegs;
        public Chair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
            set
            {
                if (value <= Furniture.zeroOrNullValue)
                {
                    throw new ArgumentOutOfRangeException("The number of legs cannot be less or equal to 0.");
                }
                this.numberOfLegs = value;
            }
        }
    }
}
