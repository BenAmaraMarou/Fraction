using NUnit.Framework;
using System;

namespace fraction_kata.Tests
{
    public class DivideFractionTest
    {
        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(5)]
        public void ZeroNumerator(int nonZero)
        {
            Assert.AreEqual(new Fraction(0), new Fraction(0).Divide(new Fraction(nonZero)));
        }
        
        [TestCase(1)]
        [TestCase(8)]
        [TestCase(0)]
        [TestCase(-3)]
        public void OneDenominator(int numerator)
        {
            Assert.AreEqual(new Fraction(numerator), new Fraction(numerator).Divide(new Fraction(1)));
        }
        
        [Test]
        public void PositiveFractions()
        {
            Assert.AreEqual(new Fraction(7, 2), new Fraction(1, 2).Divide(new Fraction(1, 7)));
        }

        [Test]
        public void NegativeFractions()
        {
            Assert.AreEqual(new Fraction(-4, 3), new Fraction(1, -3).Divide(new Fraction(-1, -4)));
        }

        [Test]
        public void ReduceToOne()
        {
            Assert.AreEqual(new Fraction(1), new Fraction(5, 3).Divide(new Fraction(5, 3)));
        }

        [Test]
        public void Reduce()
        {
            Assert.AreEqual(new Fraction(1, 2), new Fraction(2, 8).Divide(new Fraction(1, 2)));
        }
        
        [Test]
        public void ThrowExceptionWhenDenominatorIsZero()
        {
            var exception = Assert.Throws<DivideByZeroException>(() => new Fraction(3, 4).Divide(new Fraction(0)));
            Assert.That(exception.Message, Is.EqualTo("Division by '0' is not allowed."));
        }
    }
}
