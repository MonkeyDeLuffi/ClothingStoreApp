using System;

namespace Polimorfism
{
     class Pants : Product
    {
        public string Material { get; private set; }

        public Pants(string Name, string ProducingCountry, int Price,string Material)
        {
            this.Name = Name;
            this.ProducingCountry = ProducingCountry;
            this.Price = Price;
            this.Material = Material;
        }
    }
}
