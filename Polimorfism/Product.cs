using System;


namespace Polimorfism
{
     class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ProducingCountry { get; set; }

        public virtual  double GetDiscountPrice(Buyer buyer)
        {
            if (buyer.Spent <= 5000)
            {
                return Price * 0.97;
            }
            if (buyer.Spent <= 12000)
            {
                return Price * 0.9;
            }
            return Price * 0.86;
        }
    }
   
}
