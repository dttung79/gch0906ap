using System;

namespace FractionProject
{
    public class SimpleFraction : Fraction
    {
        public SimpleFraction()
        {
            int ucln = UCLN(Numerator, Denominator);
            Numerator /= ucln;
            Denominator /= ucln;
        }

        public SimpleFraction(int n, int d) : base(n, d)
        {
            int ucln = UCLN(Numerator, Denominator);
            Numerator /= ucln;
            Denominator /= ucln;
        }

        private SimpleFraction Simple(Fraction f)
        {
            return new SimpleFraction(f.Numerator, f.Denominator);
        }
        private int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
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