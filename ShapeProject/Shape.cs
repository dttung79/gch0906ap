using System;

namespace ShapeProject
{
    public abstract class Shape
    {
        public string Name { get; set; }
        protected string type;
        public string Type 
        {
            get { return type; }
        }
        // default constructor
        public Shape()
        {
            Name = "No name";
            type = "Shape";
        }
        // constructor with parameters
        public Shape(string name)
        {
            Name = name;
            type = "Shape";
        }
        public abstract double Area();
        
        public abstract double Perimeter();
        
        public override string ToString()
        {
            return String.Format("{0} {1}, S = {2:0.00}, P = {3:0.00}", Type , Name, Area(), Perimeter());
        }
    }
}