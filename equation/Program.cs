using System;

namespace equation
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadEquation eq1 = EnterEquationAndSolve();
            QuadEquation eq2 = EnterEquationAndSolve();

            // compare number of roots of eq1 and eq2 and write 
            // which one has more roots
            int n1 = eq1.NumberOfRoots();
            int n2 = eq2.NumberOfRoots();
            if (n1 == n2)
            {
                System.Console.WriteLine("Both have {0} roots", n1);
            }
            else if (n1 > n2)
            {
                System.Console.WriteLine("eq1 has more roots");
            }
            else
            {
                System.Console.WriteLine("eq2 has more roots");
            }

        }

        public static QuadEquation EnterEquationAndSolve()
        {
            double a, b, c;
            // Ask user to enter a, b, c, create a QuadEquation object
            System.Console.WriteLine("Enter a: ");
            a = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter b: ");
            b = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter c: ");
            c = double.Parse(System.Console.ReadLine());
            QuadEquation equation = new QuadEquation(a, b, c);
            // show eq1
            equation.Show();
            // solve eq1
            System.Console.WriteLine("Do you want to show roots (y/n)?");
            string showRoots = System.Console.ReadLine();
            // if (answer == "y") equation.Solve(true);
            // else equation.Solve(false);
            equation.Solve(showRoots == "y");

            return equation;
        }
    }
}
