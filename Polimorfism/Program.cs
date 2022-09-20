using Polimorfism;
using System.Reflection.Metadata;

var buyer = new Buyer
    (
       "Олексій",
       "Волк стрит",
        15000,
        12000
    );

Console.WriteLine("Список товарів:");
Console.WriteLine();

var sneakers = new Sneakers
    (
    "Air Force",
    "USA",
    5600,
    46
    );
Console.WriteLine
    (
    "Кросівки: \n",
    "Назва:    \n" + sneakers.Name,
    "Ціна:     \n" + sneakers.Price,
    "Виробник: \n" + sneakers.ProducingCountry,
    "Розмір:   \n" + sneakers.Size
    );
Console.WriteLine(new String('-',25));

var pants = new Pants
    (
    "Nike Swoosh",
    "USA",
    2300,
    "Fleece"
    );
Console.WriteLine
    (
    "Штани:    \n",
    "Назва:    \n" + pants.Name,
    "Ціна:     \n" + pants.Price,
    "Виробник: \n" + pants.ProducingCountry,
    "Матеріал: \n" + pants.Material
    );
Console.WriteLine(new String('-', 25));

var jacketAutumn = new Jackets
    (
    "The North Face",
    "Kanada",
    8900,
    "Fleece"
    );
Console.WriteLine
    (
    "Куртка осіння:   \n",
    "Назва:           \n" + jacketAutumn.Name,
    "Ціна:            \n" + jacketAutumn.Price,
    "Виробник:        \n" + jacketAutumn.ProducingCountry,
    "Состав:          \n" + jacketAutumn.Composition
    );
Console.WriteLine(new String('-', 25));

var jacketWinter = new Jackets
    (
    "Patagonia",
    "Kanada",
    7300,
    "Fluff"
    );
Console.WriteLine
    (
    "Куртка зимня:   \n",
    "Назва:          \n" + jacketWinter.Name,
    "Ціна:           \n" + jacketWinter.Price,
    "Виробник:       \n" + jacketWinter.ProducingCountry,
    "Состав:         \n" + jacketWinter.Composition
    );
Console.WriteLine(new String('-', 25));

var products = new Product[]
{
    sneakers,
    pants,
    jacketAutumn,
    jacketWinter
};

var informer = new Informer();

while (true)
{
    Console.WriteLine();
    Console.WriteLine($"Добрий день {buyer.Name},\nВаш баланс:{buyer.Balance}");

    for (int i = 0; i < products.Length; i++)
    {
        Console.WriteLine($"Товар {i}: {products[i].Name} за ціною {products[i].Price}");
    }
    Console.WriteLine("Виберіть номер товару та нажміть Enter ");

    string? str = Console.ReadLine();
    int productNumber = Convert.ToInt32(str);

    if (productNumber >= 0 && productNumber < products.Length)
    {
        if (products[productNumber].Price < buyer.Balance)
        {
            informer.Buy(buyer, products[productNumber]);
        }
        else
        {
            Console.WriteLine("У Вас недостатньо коштів");
        }
    }
    else
    {
        Console.WriteLine("Таких товарів немає ");
    }
   
}