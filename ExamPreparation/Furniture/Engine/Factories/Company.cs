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
        private const int minNameLength = 5;
        private const int standartRegNumLength = 10;

        private ICollection<IFurniture> furnitures;
        private string name;
        private string registrationNumber;

        public Company(string name, string registrationNumber)
        {
            if (!(String.IsNullOrEmpty(name)) && name.Length < minNameLength
                && (registrationNumber.Length == standartRegNumLength))
                this.name = name;
            this.registrationNumber = registrationNumber;
            this.furnitures = new Collection<IFurniture>();
        }
        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
            private set { }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            //(company name) – (number of furniture/”no”) (“furniture”/”furnitures”)
            //(information about furniture)
            //(information about furniture)
            //(information about furniture)
            var output = new StringBuilder();
            output.AppendLine(String.Format("{0} - {1} {2}", this.name, furnitures.Count > 0 ? furnitures.Count.ToString() : "no", furnitures.Count == 1 ?
                "furniture" : "furnitures"));
            return output.ToString();
        }

        public IFurniture Find(string model)
        {

            foreach (var furn in furnitures)
            {
                if (furn.Model == model)
                {
                    return furn;
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
