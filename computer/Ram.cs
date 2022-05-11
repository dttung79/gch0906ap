using System;

namespace computer
{
    public class Ram
    {
        // declare attributes: brand, price, capacity
        private string brand;
        private int price;
        private int capacity;
        // write properties for each attribute, validate values
        public string Brand
        {
            get { return brand; }
            set 
            {
                if (value == "")
                {
                    System.Console.WriteLine("Brand cannot be empty");
                    return;
                }
                brand = value;
            }
        }
        public int Price
        {
            get { return price; }
            set 
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Price cannot be negative");
                    return;
                }
                price = value;
            }
        }
        public int Capacity
        {
            get { return capacity; }
            set 
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Capacity cannot be negative");
                    return;
                }
                capacity = value;
            }
        }
        // write 2 constructors: default and parameterized
        public Ram()
        {
            brand = "Kingston";
            price = 100;
            capacity = 8;
        }
        public Ram(string brand, int price, int capacity)
        {
            this.brand = brand;
            this.price = price;
            this.capacity = capacity;
        }
        // write method to show Ram info
        public void ShowInfo()
        {
            System.Console.WriteLine("Brand: {0}", brand);
            System.Console.WriteLine("Price: ${0} ", price);
            System.Console.WriteLine("Capacity: {0} GB", capacity);
        }
    }
}