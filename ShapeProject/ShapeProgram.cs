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
            Console.WriteLine("3. Create a square");
            Console.WriteLine("4. Create a triangle");
            Console.WriteLine("5. Create an equal triangle");
            Console.WriteLine("6. Print all shapes");
        }

        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: CreateCircle(); break;
                case 2: CreateRectangle(); break;
                case 3: CreateSquare(); break;
                case 4: CreateTriangle(); break;
                case 5: CreateEqualTriangle(); break;
                case 6: PrintAllShapes(); break;
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
        private void CreateSquare()
        {
            Console.WriteLine("Enter the square's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the square's side: ");
            double side = double.Parse(Console.ReadLine());
            Square s = new Square(name, side);
            shapes.Add(s);
        }
        private void CreateTriangle()
        {
            Console.WriteLine("Enter the triangle's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the triangle's side A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the triangle's side B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the triangle's side C: ");
            double c = double.Parse(Console.ReadLine());
            Triangle t = new Triangle(name, a, b, c);
            shapes.Add(t);
        }
        private void CreateEqualTriangle()
        {
            Console.WriteLine("Enter the triangle's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the triangle's side: ");
            double side = double.Parse(Console.ReadLine());
            EqualTriangle t = new EqualTriangle(name, side);
            shapes.Add(t);
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