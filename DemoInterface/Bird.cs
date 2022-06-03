using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class Bird
    {
        public string FeatherColor { get; set; }
        protected string type;
        public string Type { get { return type; } }
        public Bird(string color)
        {
            FeatherColor = color;
        }
        public override String ToString()
        {
            return FeatherColor + " " + Type;
        }
    }

    public class Eagle : Bird, IFlyable
    {
        public Eagle(string color) : base(color)
        {
            type = "Eagle";
        }
        public void Fly()
        {
            Console.WriteLine("Flying to hunt.");
        }
    }
    public class Pigeon : Bird, IFlyable
    {
        public Pigeon(string color) : base(color)
        {
            type = "Pigeon";
        }
        public void Fly()
        {
            Console.WriteLine("Flying to send emails.");
        }
    }

    public class Penguin : Bird
    {
        public Penguin(string color) : base(color)
        {
            type = "Penguin";
        }
        public void Swim()
        {
            Console.WriteLine("Swimming to find MH370.");
        }
    }
}