using System;

namespace FractionConsole
{
    public class SimpleFraction : Fraction
    {
        public SimpleFraction()
        {

        }

        public SimpleFraction(int n, int d) : base(n, d)
        {

        }

        private SimpleFraction Simple(Fraction f)
        {
            int uscln = USCLN(f.Numerator, f.Denominator);
            int n = f.Numerator / uscln;
            int d = f.Denominator / uscln;
            return new SimpleFraction(n, d);
        }
        private int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }

        public override Fraction Add(Fraction f)
        {
            SimpleFraction s = Simple(base.Add(f));
            return s;
        }

        public override Fraction Sub(Fraction f)
        {
            SimpleFraction s = Simple(base.Sub(f));
            return s;
        }

        public override Fraction Mul(Fraction f)
        {
            SimpleFraction s = Simple(base.Mul(f));
            return s;
        }

        public override Fraction Div(Fraction f)
        {
            SimpleFraction s = Simple(base.Div(f));
            return s;
        }
    }
}