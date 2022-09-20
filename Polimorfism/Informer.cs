using System;


namespace Polimorfism
{
     class Informer
    {
        public void Buy(Buyer buyer,Product product)
        {
            double Price = product.GetDiscountPrice(buyer);
            buyer.ReduceBalance(Price);
            Console.WriteLine($"{buyer.Name} купив {product.Name} за {Price}.Заказ відправлений на склад.");
        }
    }
}
