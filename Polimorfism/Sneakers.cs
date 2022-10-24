using System;


namespace Polimorfism
{
     class Sneakers : Product
    {

        public int Size { get; set; }

        public Sneakers(string Name,string ProducingCountry, int Price,int Size)
        {
            this.Name = Name;
            this.ProducingCountry = ProducingCountry;
            this.Price = Price;
            this.Size = Size;
        }
    }
}
