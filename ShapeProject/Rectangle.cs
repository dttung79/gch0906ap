using System;

namespace ShapeProject
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle()
        {
            Width = 1.0;
            Height = 2.0;
            Name = "ABCD";
            type = "Rectangle";
        }
        public Rectangle(string name, double width, double height)
        {
            Width = width;
            Height = height;
            Name = name;
            type = "Rectangle";
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}