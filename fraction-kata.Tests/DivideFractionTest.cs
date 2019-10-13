using NUnit.Framework;

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
        public void NonMultipleFractions()
        {
            Assert.AreEqual(new Fraction(7, 2), new Fraction(1, 2).Divide(new Fraction(1, 7)));
        }
    }
}
