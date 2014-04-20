namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        private decimal area;

        public Table(string model, MaterialType material, decimal price, decimal height, decimal length, decimal width)
            : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
            this.Area = this.Length * this.Width;
        }
        public decimal Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= Furniture.zeroOrNullValue)
                {
                    throw new ArgumentOutOfRangeException("The table's length cannot be less or equal to 0.");
                }
                this.length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= Furniture.zeroOrNullValue)
                {
                    throw new ArgumentOutOfRangeException("The table's width cannot be less or equal to 0.");
                }
                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.area;
            }
            private set
            {
                this.area = value;
            }
        }
    }
}
