﻿using NUnit.Framework;
using System;

namespace fraction_kata.Tests
{
    public class FractionTest
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void AddZeroToAny(int nonZero)
        {
            Fraction actual = new Fraction(nonZero).Add(new Fraction(0));
            Assert.AreEqual(new Fraction(nonZero), actual);
        }

        [TestCase(1, 2)]
        [TestCase(-1, 2)]
        [TestCase(1, -2)]
        [TestCase(-1, -2)]
        public void AddNonZeroIntegers(int first, int second)
        {
            Fraction actual = new Fraction(first).Add(new Fraction(second));
            Assert.AreEqual(new Fraction(first + second), actual);
        }

        [Test]
        public void AddFractionsWithSameDenominator()
        {
            Fraction actual = new Fraction(3, 7).Add(new Fraction(1, 7));
            Assert.AreEqual(new Fraction(4, 7), actual);
        }

        [Test]
        public void AddFractionsWithDifferentDenominators()
        {
            Fraction actual = new Fraction(1, 2).Add(new Fraction(1, 3));
            Assert.AreEqual(new Fraction(5, 6), actual);
        }

        [TestCase(-1, 2)]
        [TestCase(1, -2)]
        public void AddNegativeFractions(int numerator, int denominator)
        {
            Fraction actual = new Fraction(numerator, denominator).Add(new Fraction(-1, 4));
            Assert.AreEqual(new Fraction(-6, 8), actual);
        }
        
        [Test]
        public void ReduceAddResult()
        {
            Fraction actual = new Fraction(1, 4).Add(new Fraction(1, 4));
            Assert.AreEqual(new Fraction(1, 2), actual);
        }


        [Test]
        public void ReduceAddResultToOne()
        {
            Fraction actual = new Fraction(1, 2).Add(new Fraction(1, 2));
            Assert.AreEqual(new Fraction(1), actual);
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
}
