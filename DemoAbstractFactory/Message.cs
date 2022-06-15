using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAbstractFactory
{
    public abstract class Message
    {
        protected List<string> content;
        public Message()
        {
            content = new List<string>();
        }
        public void AddLine(string line)
        {
            content.Add(line);
        }
        public abstract void Print();
    }
    public class SimpleMessage : Message
    {
        public SimpleMessage() : base()
        {
        }
        public override void Print()
        {
            foreach(string line in content)
            {
                Console.Write("| " + line);
                for (int i = 0; i < 50 - line.Length - 3; i++) Console.Write(" ");
                Console.WriteLine("|");
            }
            for (int i = 0; i < 50; i++) Console.Write("-");
            Console.WriteLine();
        }
    }

    public class FancyMessage : Message
    {
        public override void Print()
        {
            foreach (string line in content)
            {
                Console.Write("*");
                for (int i = 0; i < (48 - line.Length) / 2; i++) Console.Write(" ");
                Console.Write(line);
                for (int i = 0; i < (48 - line.Length) / 2; i++) Console.Write(" ");
                if (line.Length % 2 == 0) Console.WriteLine("*");
                else Console.WriteLine(" *");
            }
            Console.Write("*");
            for (int i = 0; i < 48; i++) Console.Write("~");
            Console.WriteLine("*");
        }
    }
}