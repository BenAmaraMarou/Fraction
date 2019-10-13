using NUnit.Framework;
using System;

namespace fraction_kata.Tests
{
    public class AddFractionTest
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void Zero(int number)
        {
            Assert.AreEqual(new Fraction(number), new Fraction(number).Add(new Fraction(0)));
        }

        [TestCase(1, 2)]
        [TestCase(-1, 2)]
        [TestCase(1, -2)]
        [TestCase(-1, -2)]
        public void NonZeroIntegers(int first, int second)
        {
            Assert.AreEqual(new Fraction(first + second), new Fraction(first).Add(new Fraction(second)));
        }

        [Test]
        public void SameDenominator()
        {
            Assert.AreEqual(new Fraction(4, 7), new Fraction(3, 7).Add(new Fraction(1, 7)));
        }

        [Test]
        public void DifferentDenominators()
        {
            Assert.AreEqual(new Fraction(5, 6), new Fraction(1, 2).Add(new Fraction(1, 3)));
        }

        [TestCase(-1, 2)]
        [TestCase(1, -2)]
        public void NegativeFractions(int numerator, int denominator)
        {
            Assert.AreEqual(new Fraction(-6, 8), new Fraction(numerator, denominator).Add(new Fraction(-1, 4)));
        }

        [Test]
        public void ReduceSameDenominator()
        {
            Assert.AreEqual(new Fraction(1, 2), new Fraction(1, 4).Add(new Fraction(1, 4)));
        }

        [Test]
        public void ReduceToOne()
        {
            Assert.AreEqual(new Fraction(1), new Fraction(1, 2).Add(new Fraction(1, 2)));
        }

        [Test]
        public void ReduceFractionsWithMultipleDenominators()
        {
            Assert.AreEqual(new Fraction(11, 8), new Fraction(3, 4).Add(new Fraction(5, 8)));
        }

        [Test]
        public void ReduceFractionsWithNonMultipleDenominators()
        {
            Assert.AreEqual(new Fraction(13, 6), new Fraction(2, 3).Add(new Fraction(6, 4)));
        }

        [Test]
        public void ThrowExceptionWhenDenominatorIsZero()
        {
            var exception = Assert.Throws<DivideByZeroException>(() => new Fraction(1, 0));
            Assert.That(exception.Message, Is.EqualTo("Fraction with '0' denominator is not allowed."));
        }
    }
}
