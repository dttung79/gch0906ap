using System;

namespace ShopManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 3 products (Shirt - 100, Shoe - 100, Hat - 100)
            Product shirt = new Product("Shirt", 100, 10);
            Product shoe = new Product("Shoe", 100, 10);
            Product hat = new Product("Hat", 100, 10);
            // create 3 saler, each is in charge of 1 product
            Saler john = new Saler("John");
            john.AssignProduct(shirt);
            Saler jane = new Saler("Jane");
            jane.AssignProduct(shoe);
            Saler jack = new Saler("Jack");
            jack.AssignProduct(hat);
            // create a shop, add products, salers to shop
            Shop shop = new Shop("Fashion Shop");
            shop.AddProduct(shirt);
            shop.AddProduct(shoe);
            shop.AddProduct(hat);
            shop.AddSaler(john);
            shop.AddSaler(jane);
            shop.AddSaler(jack);

            // repeat 3 times
            for (int i = 0; i < 3; i++)
            {
                // ask user enter product name to buy
                Console.WriteLine("Enter product name to buy: ");
                string name = Console.ReadLine();
                // ask number of products to buy
                Console.WriteLine("Enter number of products to buy: ");
                int n = int.Parse(Console.ReadLine());
                // sell products  
                shop.SellProduct(name, n);
            }
            

            // show all products, all salers   
            shop.ShowAllProducts();
            shop.ShowAllSalers();     
        }
    }
}
