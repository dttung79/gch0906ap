using System;

namespace FractionProject
{
    public class FractionProgram : MenuProgram
    {
        protected override void PrintMenu()
        {
            Console.WriteLine("_________________________");
            Console.WriteLine("1: Add");
            Console.WriteLine("2: Subtract");
            Console.WriteLine("3: Multiply");
            Console.WriteLine("4: Divide");
        }

        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: DemoAddFactions(); break;
                case 2: DemoSubtractFactions(); break;
                case 3: DemoMultiplyFactions(); break;
                case 4: DemoDivideFactions(); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
        private Fraction AddFactions(string message)
        {
            // bool valid = false;
            while (true)
            {
                try
                {
                    Console.WriteLine(message);
                    int n = GetNumber("Enter numerator");
                    int d = GetNumber("Enter denominator");
                    return new Fraction(n, d);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private int GetNumber(string message)
        {
            Console.WriteLine(message);
            bool valid = false;
            int n = 0;
            while (!valid)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format, please try again");
                    Console.WriteLine(message);
                }
            }
            return n;
        }
        private void DemoAddFactions()
        {
            Fraction f1 = AddFactions("Enter first Fraction: ");
            Fraction f2 = AddFactions("Enter second Fraction: ");
            SimpleFraction sf1 = new SimpleFraction(f1.Numerator, f1.Denominator);
            SimpleFraction sf2 = new SimpleFraction(f2.Numerator, f2.Denominator);
            Fraction f3 = sf1.Add(sf2);
            Console.WriteLine("{0} + {1} = {2}", f1, f2, f3);
        }
        private void DemoSubtractFactions()
        {
            Fraction f1 = AddFactions("Enter first Fraction: ");
            Fraction f2 = AddFactions("Enter second Fraction: ");
            Fraction f3 = f1.Sub(f2);
            Console.WriteLine("{0} - {1} = {2}", f1, f2, f3);
        }
        private void DemoMultiplyFactions()
        {
            Fraction f1 = AddFactions("Enter first Fraction: ");
            Fraction f2 = AddFactions("Enter second Fraction: ");
            Fraction f3 = f1.Mul(f2);
            Console.WriteLine("{0} X {1} = {2}", f1, f2, f3);
        }
        private void DemoDivideFactions()
        {
            Fraction f1 = AddFactions("Enter first Fraction: ");
            while (true)
            {
                try
                {
                    Fraction f2 = AddFactions("Enter second Fraction: ");
                    Fraction f3 = f1.Sub(f2);
                    Console.WriteLine("{0} % {1} = {2}", f1, f2, f3);
                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Second Fraction cannot have numerator equal zero");
                }
            }
        }
    }
}