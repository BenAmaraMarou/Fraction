using NUnit.Framework;
using System;

namespace fraction_kata.Tests
{
    public class FractionTests
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void AddZeroToAny(int nonZero)
        {
            Fraction actual = new Fraction(nonZero).Add(new Fraction(0));
            Assert.AreEqual(nonZero, actual.Numerator());
            Assert.AreEqual(1, actual.Denominator());
            Assert.AreEqual(new Fraction(nonZero), actual);
        }

        [Test]
        public void AddPositiveIntegers()
        {
            Fraction actual = new Fraction(1).Add(new Fraction(2));
            Assert.AreEqual(3, actual.Numerator());
            Assert.AreEqual(1, actual.Denominator());
        }

        [Test]
        public void AddNegativeIntegers()
        {
            Fraction actual = new Fraction(-1).Add(new Fraction(-2));
            Assert.AreEqual(-3, actual.Numerator());
            Assert.AreEqual(1, actual.Denominator());
        }

        [Test]
        public void AddFractionsWithSameDenominator()
        {
            Fraction actual = new Fraction(3, 7).Add(new Fraction(1, 7));
            Assert.AreEqual(4, actual.Numerator());
            Assert.AreEqual(7, actual.Denominator());
        }

        [Test]
        public void AddFractionsWithDifferentDenominators()
        {
            Fraction actual = new Fraction(1, 2).Add(new Fraction(1, 3));
            Assert.AreEqual(5, actual.Numerator());
            Assert.AreEqual(6, actual.Denominator());
        }

        [Test]
        public void AddNegativeFractionsOnNumerator()
        {
            Fraction actual = new Fraction(-1, 2).Add(new Fraction(-1, 4));
            Assert.AreEqual(-6, actual.Numerator());
            Assert.AreEqual(8, actual.Denominator());
        }

        [Test]
        public void AddNegativeFractionsOnDenominator()
        {
            Fraction actual = new Fraction(1, -2).Add(new Fraction(-1, 4));
            Assert.AreEqual(-6, actual.Numerator());
            Assert.AreEqual(8, actual.Denominator());
        }

        [Test]
        public void AddFractionsWithSameNegativeDenominator()
        {
            Fraction actual = new Fraction(1, -7).Add(new Fraction(2, -7));
            Assert.AreEqual(-3, actual.Numerator());
            Assert.AreEqual(7, actual.Denominator());
        }

        private class Fraction : IEquatable<Fraction>
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

            internal Fraction Add(Fraction fraction)
            {
                if(_denominator != fraction._denominator)
                {
                    return new Fraction(_numerator * fraction._denominator + _denominator * fraction._numerator, _denominator * fraction._denominator);
                }
                return new Fraction(_numerator + fraction._numerator, _denominator);
            }

            internal int Denominator()
            {
                return _denominator;
            }

            internal int Numerator()
            {
                return _numerator;
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
}
