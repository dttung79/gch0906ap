using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopManagement
{
    public class Saler
    {
        public string Name { get; set; }
        private static int count = 0;
        private int id;
        public int Id
        {
            get { return id; }
        }
        private int nProducts;
        public int NProducts
        {
            get { return nProducts; }
        }
        private Product prod;
        public Product Prod
        {
            get { return prod; }
        }

        public Saler(string name)
        {
            Name = name;
            id = count++;
            nProducts = 0;
            prod = new Product();
        }

        public void AssignProduct(Product p)
        {
            prod = p;
        }

        public void SellProduct(int n)
        {
            if (n > prod.Number)
            {
                Console.WriteLine("Not enough product");
                return;
            }
            prod.Export(n);
            nProducts += n;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Saler Name: {0}", Name);
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Product in charge: {0}", prod.Name);
            Console.WriteLine("Number of sold products: {0}", NProducts);
            Console.WriteLine("Income: ${0}", NProducts * prod.Price);
        }

    }
}