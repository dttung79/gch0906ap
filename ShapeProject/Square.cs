using System;

namespace ShapeProject
{
    public class Square : Rectangle
    {
        public double Side
        {
            get { return Width; }
        }
        public Square() : base("ABCD", 1.0, 1.0)
        {
            type = "Square";
        }
        public Square(string name, double side) : base(name, side, side)
        {
            type = "Square";
        }

    }
}