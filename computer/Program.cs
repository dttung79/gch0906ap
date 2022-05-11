using System;

namespace computer
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a Ram object
            Ram ram = new Ram("Kingston", 100, 8);
            CPU cpu = new CPU("Intel", 500, 2.4);
            Computer computer = new Computer("Intel", ram, cpu);
            computer.DisplaySpecs();
            // Home work:
            // Write class Disk with attributes: brand, price, capacity, speed
            // add Disk object to the Computer class
            // write program ask user to enter Ram, Cpu, Disk infor
            // create a new Computer object with these objects
            // display the computer's specs
        }
    }
}
