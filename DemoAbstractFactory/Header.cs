using System;

namespace DemoAbstractFactory
{
    public abstract class Header
    {
        public string Title { get; set; }
        public abstract void Print();
        public Header(string title)
        {
            Title = title;
        }
    }
    public class SimpleHeader : Header
    {
        public SimpleHeader(string title) : base(title)
        {
        }
        public override void Print()
        {
            for (int i = 0; i < 50; i++) Console.Write("-");
            Console.WriteLine();

            Console.Write("| " + Title);
            for (int i = 0; i < 50 - Title.Length - 3; i++) Console.Write(" ");
            Console.WriteLine("|");

            for (int i = 0; i < 50; i++) Console.Write("-");
            Console.WriteLine();
        }
    }

    public class FancyHeader : Header
    {
        public FancyHeader(string title) : base(title)
        {
        }
        public override void Print()
        {
            Console.Write("*");
            for (int i = 0; i < 48; i++) Console.Write("~");
            Console.WriteLine("*");

            Console.Write("|");
            for (int i = 0; i < (48 - Title.Length)/2; i++) Console.Write(" ");
            Console.Write(Title);
            for (int i = 0; i < (48 - Title.Length)/2; i++) Console.Write(" ");
            if (Title.Length % 2 == 0) Console.WriteLine("|");
            else Console.WriteLine(" |");

            Console.Write("*");
            for (int i = 0; i < 48; i++) Console.Write("~");
            Console.WriteLine("*");
        }
    }
}