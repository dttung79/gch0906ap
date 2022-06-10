using System;

namespace FractionProject
{
    public class Fraction
    {
        public int Numerator { get; set; }
        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            set 
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denominator cannot be zero");
                }
                denominator = value;
            }
        }
        // default constructor
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }
        // constructor with parameters
        public Fraction(int n, int d)
        {
            Numerator = n;
            Denominator = d;
        }
        public virtual Fraction Add(Fraction f)
        {
            int n = Numerator * f.Denominator + Denominator * f.Numerator;
            int d = Denominator * f.Denominator;
            return new Fraction(n, d);
        }
        public virtual Fraction Sub(Fraction f)
        {
            int n = Numerator * f.Denominator - Denominator * f.Numerator;
            int d = Denominator * f.Denominator;
            return new Fraction(n, d);
        }
        public virtual Fraction Mul(Fraction f)
        {
            int n = Numerator * f.Numerator;
            int d = Denominator * f.Denominator;
            return new Fraction(n, d);
        }
        public virtual Fraction Div(Fraction f)
        {
            int n = Numerator * f.Denominator;
            int d = Denominator * f.Numerator;
            return new Fraction(n, d);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }

    }
}