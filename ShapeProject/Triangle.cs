using System;

namespace ShapeProject
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        // default constructor
        public Triangle() : base("ABC")
        {
            type = "Triangle";
            SideA = 3; SideB = 4; SideC = 5;
        }
        // parameterized constructor
        public Triangle(string name, double a, 
                        double b, double c) : base(name)
        {
            type = "Triangle";
            SideA = a; SideB = b; SideC = c;
        }
        // override the Area() method
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        // override the Perimeter() method
        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}