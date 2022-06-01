using System;
using System.Collections.Generic;

namespace ShapeProject
{
    public class ShapeProgram : MenuProgram
    {
        private List<Shape> shapes;
        public ShapeProgram()
        {
            shapes = new List<Shape>();
        }
        protected override void PrintMenu()
        {
            Console.WriteLine("1. Create a circle");
            Console.WriteLine("2. Create a rectangle");
            Console.WriteLine("3. Print all shapes");
        }

        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: CreateCircle(); break;
                case 2: CreateRectangle(); break;
                case 3: PrintAllShapes(); break;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
        private void CreateCircle()
        {
            Console.WriteLine("Enter the circle's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the circle's radius: ");
            double radius = double.Parse(Console.ReadLine());
            Circle c = new Circle(name, radius);
            shapes.Add(c);
        }
        private void CreateRectangle()
        {
            Console.WriteLine("Enter the rectangle's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the rectangle's width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rectangle's height: ");
            double height = double.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(name, width, height);
            shapes.Add(r);
        }
        private void PrintAllShapes()
        {
            foreach (Shape s in shapes)
            {
                Console.WriteLine(s);
            }
        }
    }
}