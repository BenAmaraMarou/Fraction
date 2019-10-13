using System;

namespace fraction_kata
{
    public class Fraction : IEquatable<Fraction>
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public Fraction(int number) : this(number, 1)
        { }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Fraction with '0' denominator is not allowed.");
            }

            var sign = denominator < 0 ? -1 : 1;
            var gcd = GeatestCommonDivisor.Gcd(numerator, denominator) * sign;
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;
        }

        public Fraction Add(Fraction fraction)
        {
            return new Fraction(_numerator * fraction._denominator + _denominator * fraction._numerator, _denominator * fraction._denominator);
        }

        public Fraction Substract(Fraction fraction)
        {
            return Add(fraction.Minus());
        }

        public Fraction Minus()
        {
            return new Fraction(_numerator, _denominator * -1);
        }

        public bool Equals(Fraction other)
        {
            return _numerator == other._numerator && _denominator.Equals(other._denominator);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Fraction)obj);
        }

        public override int GetHashCode()
        {
            unchecked { return (_numerator * 397) ^ (_denominator * 397); }
        }

        public override string ToString()
        {
            return $"Fraction: Numerator={_numerator}, Denominator={_denominator}";
        }
    }
}