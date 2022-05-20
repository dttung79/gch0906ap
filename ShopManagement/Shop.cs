using System;
using System.Collections.Generic;

namespace ShopManagement
{
    public class Shop
    {
        public string Name { get; set; }
        private List<Saler> salers;
        private List<Product> products;
        public Shop(string name)
        {
            Name = name;
            salers = new List<Saler>();
            products = new List<Product>();
        }
        public void AddSaler(Saler s)
        {
            salers.Add(s);
        }
        public void AddProduct(Product p)
        {
            products.Add(p);
        }
        public Saler GetSalerByProduct(string name)
        {
            foreach (Saler s in salers)
            {
                if (s.Prod.Name == name)
                {
                    return s;
                }
            }
            return null;
        }
        public void SellProduct(string name, int numbers)
        {
            Saler s = GetSalerByProduct(name);
            if (s == null)
            {
                Console.WriteLine("No saler in charge of this product");
                return;
            }
            s.SellProduct(numbers);
        }

        public void ShowAllProducts()
        {
            foreach (Product p in products)
            {
                p.ShowInfo();
            }
        }
        public void ShowAllSalers()
        {
            foreach (Saler s in salers)
            {
                s.ShowInfo();
            }
        }
    }
}