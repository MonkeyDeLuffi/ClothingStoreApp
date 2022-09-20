using System;


namespace Polimorfism
{
     class Jackets : Product
    {
        public  string Composition  { get; private set; }

        public Jackets(string Name, string ProducingCountry, int Price,string Composition )
        {
            this.Name = Name;
            this.ProducingCountry = ProducingCountry;
            this.Price = Price;
            this.Composition = Composition;
        }

        public override double GetDiscountPrice(Buyer buyer)
        {
            return Price / 2;
        }
    }
}
