using System;

namespace computer
{
    public class Computer
    {
        // declare attribute brand, Ram object, CPU object
        private string brand;
        private Ram ram;
        private CPU cpu;
        // parameterized constructor
        public Computer(string brand, Ram ram, CPU cpu)
        {
            this.brand = brand;
            this.ram = ram;
            this.cpu = cpu;
        }
        // write a method to display the computer's specs
        public void DisplaySpecs()
        {
            Console.WriteLine("Brand: {0}", brand);
            ram.ShowInfo();
            cpu.ShowInfo();
            Console.WriteLine("Computer Price: ${0}", ram.Price + cpu.Price);
        }
    }
}