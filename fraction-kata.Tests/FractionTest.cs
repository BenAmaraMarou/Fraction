using NUnit.Framework;

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

        [Test]
        public void ReduceResultOfFractionsWithMultipleDenominators()
        {
            Fraction actual = new Fraction(3, 4).Add(new Fraction(5, 8));
            Assert.AreEqual(new Fraction(11, 8), actual);
        }
    }
}
