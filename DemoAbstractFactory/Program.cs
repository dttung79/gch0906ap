using System;

namespace DemoAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailFactory factory;
            Console.WriteLine("Email type (1 - Simple, 2 - Fancy): ");
            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 1) factory = new SimpleEmailFactory();
            else factory = new FancyEmailFactory();

            Header header = factory.CreateHeader();
            Message msg = factory.CreateMessage();
            header.Print();
            msg.Print();
        }
    }
}
