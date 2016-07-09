using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        //string name, string registrationNumber
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.name = name;
            this.registrationNumber = registrationNumber;
            this.furnitures = new Collection<IFurniture>();
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>(this.furnitures);

            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if ((!string.IsNullOrEmpty(value)) || value.Length >= 5)
                {
                    this.name = value;
                }
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            protected set
            {
                if (value.Length == 10 && value.All(char.IsDigit))
                {
                    this.registrationNumber = value;
                }
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
            var result = this.furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model).ToList();
            this.furnitures = result;
        }

        public string Catalog()
        {
            var output = new StringBuilder();
            output.Append(string.Format("{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));
            foreach (var furniture in furnitures)
            {
                output.AppendLine();
                output.Append(furniture.ToString());
            }
            return output.ToString();
        }

        public IFurniture Find(string model)
        {
            foreach (var furniture in furnitures)
            {
                if (furniture.Model.Equals(model))
                {
                    return furniture;
                }
            }
            return null;
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }
    }
}
//•	Name cannot be empty, null or with less than 5 symbols.
//•	Registration number must be exactly 10 symbols and must contain only digits.
//•	Adding duplicate furniture is allowed.
//•	Removing furniture removes the first occurance. If such is not found, nothing happens.
//•	Finding furniture by model gets the first occurance. If such is not found, return null. Searching is case insensitive.
