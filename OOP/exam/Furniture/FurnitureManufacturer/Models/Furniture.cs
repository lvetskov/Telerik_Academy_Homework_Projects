namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Furniture : IFurniture
    {
        private const int minStringLenght = 3;
        protected const decimal zeroOrNullValue = 0m;
        protected string model;
        protected MaterialType material;
        protected decimal price;
        protected decimal height;
        public Furniture(string model, MaterialType material, decimal price, decimal height)
        {
            this.Model = model;
            this.material = material;
            this.Price = price;
            this.Height = height;
        }
        public string Model
        {
            get 
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model's name cannot be empty.");
                }
                else if (value.Length < minStringLenght)
                {
                    throw new ArgumentOutOfRangeException("Model name's lenght should be at least 3 symbols.");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.material.ToString();
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
                if (value <= zeroOrNullValue)
                {
                    throw new ArgumentOutOfRangeException("The price of furniture cannot be less or equal to 0.");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= zeroOrNullValue)
                {
                    throw new ArgumentOutOfRangeException("The height of furniture cannot be less or equal to 0.");
                }
                this.height = value;
            }
        }
    }
}
