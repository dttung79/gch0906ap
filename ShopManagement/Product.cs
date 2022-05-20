using System;

namespace ShopManagement
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        private int numbers;
        public int Number 
        {
            get { return numbers; }
        }

        public Product()
        {
            Name = "Default Product";
            Price = 100;
            numbers = 0;
        }
        // parameterized constructor
        public Product(string name, int price, int numbers)
        {
            Name = name;
            Price = price;
            this.numbers = numbers;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Price: {0}", Price);
            Console.WriteLine("Number: {0}", Number);
        }
        public void Import(int n)
        {
            numbers += n;
        }
        public void Export(int n)
        {
            if (n > numbers)
            {
                Console.WriteLine("Not enough product");
                return;
            }
            numbers -= n;
        }
    }
}