using System;

namespace DemoInterface
{
    public class Airplane : IFlyable
    {
        public string Departure { get; set; }
        public string Destination { get; set; }
        public Airplane(string departure, string destination)
        {
            Departure = departure;
            Destination = destination;
        }
        public void Fly()
        {
            Console.WriteLine("Flying from {0} to {1}", Departure, Destination);
        }
    }
}