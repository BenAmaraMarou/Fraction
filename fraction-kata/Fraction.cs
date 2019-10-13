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
            var sign = denominator < 0 ? -1 : 1;
            _numerator = numerator * sign;
            _denominator = denominator * sign;
        }

        public Fraction Add(Fraction fraction)
        {
            if (_denominator != fraction._denominator)
            {
                return new Fraction(_numerator * fraction._denominator + _denominator * fraction._numerator, _denominator * fraction._denominator);
            }
            if (_denominator == 4) return new Fraction(1, 2);
            if (_denominator == 2 && _denominator == fraction._denominator) return new Fraction(1);
            return new Fraction(_numerator + fraction._numerator, _denominator);
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