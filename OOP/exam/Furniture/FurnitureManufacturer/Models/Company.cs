namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Company : ICompany
    {
        private const int minStringLenght = 5;
        private const int regNumLength = 10;
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;
        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Company's name cannot be empty.");
                }
                else if (value.Length < minStringLenght)
                {
                    throw new ArgumentOutOfRangeException("Company name's lenght should be at least 5 symbols.");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Company's reg number cannot be empty.");
                }
                else if (value.Length != (regNumLength))
                {
                    throw new ArgumentOutOfRangeException("Company reg number's lenght should exact 10 symbols.");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value, i))
                    {
                        throw new ArgumentException("All letters of the reg num should be digits.");
                    }
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
            set
            {
                this.furnitures = value;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            foreach (var item in furnitures)
            {
                if (item.Model == model)
                {
                    return item;
                }
            }
            return null;
            //   return this.furnitures.First(x => x.Model == model);
        }

        public string Catalog()
        {
            StringBuilder output = new StringBuilder();
            StringBuilder outputTwo = new StringBuilder();
            output.AppendFormat("{0} - {1} - {2} {3}",
                                this.Name,
                                this.RegistrationNumber,
                                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                                this.Furnitures.Count != 1 ? "furnitures" : "furniture"
                                );
            var listedFurnitures = furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model);
            foreach (var item in listedFurnitures)
            {
                if (item.GetType().Name == "Table")
                {
                    var itemAsTable = item as Table;
                    output.AppendLine("");
                    output.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}",
                    itemAsTable.GetType().Name, itemAsTable.Model, itemAsTable.Material, itemAsTable.Price, itemAsTable.Height, itemAsTable.Length, itemAsTable.Width, itemAsTable.Area);
                    break;
                }
                else if (item.GetType().Name == "AdjustableChair")
                {
                    var itemAsAdjustableChair = item as AdjustableChair;
                    output.AppendLine("");
                    output.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}",
                    itemAsAdjustableChair.GetType().Name, itemAsAdjustableChair.Model, itemAsAdjustableChair.Material, itemAsAdjustableChair.Price, itemAsAdjustableChair.Height, itemAsAdjustableChair.NumberOfLegs);
                    break;
                }
                else if (item.GetType().Name == "ConvertibleChair")
                {
                    var itemAsConvertableChair = item as ConvertibleChair;
                    output.AppendLine("");
                    output.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}",
                        itemAsConvertableChair.GetType().Name, itemAsConvertableChair.Model, itemAsConvertableChair.Material, itemAsConvertableChair.Price, itemAsConvertableChair.Height, itemAsConvertableChair.NumberOfLegs, itemAsConvertableChair.IsConverted ? "Converted" : "Normal");
                    break;
                }
                else if (item.GetType().Name == "Chair")
                {
                    var itemAsChair = item as Chair;
                    output.AppendLine("");
                    output.AppendFormat("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}",
                    itemAsChair.GetType().Name, itemAsChair.Model, itemAsChair.Material, itemAsChair.Price, itemAsChair.Height, itemAsChair.NumberOfLegs);
                    break;
                }
            }
            return output.ToString();

        }
    }
}
