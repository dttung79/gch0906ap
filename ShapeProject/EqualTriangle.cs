using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    
    public class EqualTriangle : Triangle
    {
        public double Side
        {
            get { return SideA; }
        }
        public EqualTriangle() : base("ABC", 1.0, 1.0, 1.0)
        {
            type = "Equal Triangle";
        }
        public EqualTriangle(string name, double side) : 
                                        base(name, side, side, side)
        {
            type = "Equal Triangle";
        }
    }
}