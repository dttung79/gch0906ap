using System;

namespace computer
{
    public class CPU
    {
        // declare attributes: brand, price, speed
        private string brand;
        private int price;
        private double speed;

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
        public double Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Speed cannot be negative");
                    return;
                }
                speed = value;
            }
        }
        // write 2 constructors: default and parameterized
        public CPU()
        {
            brand = "Intel";
            price = 500;
            speed = 2.4;
        }
        public CPU(string brand, int price, double speed)
        {
            this.brand = brand;
            this.price = price;
            this.speed = speed;
        }
        // write method to show CPU info
        public void ShowInfo()
        {
            System.Console.WriteLine("Brand: {0}", brand);
            System.Console.WriteLine("Price: ${0}", price);
            System.Console.WriteLine("Speed: {0} Ghz", speed);
        }
    }
}