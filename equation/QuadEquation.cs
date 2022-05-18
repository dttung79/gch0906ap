using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace equation
{
    public class QuadEquation
    {
        private double a;
        private double b;
        private double c;

        // default constructor
        public QuadEquation()
        {
            a = 1;
            b = 2;
            c = 1;
        }
        // parameterized constructor
        public QuadEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool IsValid()
        {
            return a != 0;
        }

        public int NumberOfRoots()
        {
            if (!IsValid()) return -1;
            double delta = b * b - 4 * a * c;
            if (delta < 0) return 0;
            if (delta == 0) return 1;
            return 2;
        }
        public void Solve(bool showRoot)
        {
            if (!IsValid())
            {
                Console.WriteLine("Invalid equation");
                return;
            }
            if (!showRoot)
            {
                ShowNumberOfRoots();
            }
            else 
            {
                ShowAllRoots();
            }
            
        }
        private void ShowAllRoots()
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0) System.Console.WriteLine("No roots");
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                System.Console.WriteLine("One root: {0}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                System.Console.WriteLine("Two roots: {0} and {1}", x1, x2);
            }
        }
        private void ShowNumberOfRoots()
        {
            int n = NumberOfRoots();
            System.Console.WriteLine("Number of roots: {0}", n);
        }
        public void Show()
        {
            System.Console.WriteLine("{0}x^2 + {1}x + {2} = 0", a, b, c);
        }
    }
}