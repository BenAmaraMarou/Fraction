using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class FractionTests
    {
        [TestCase(1)]
        [TestCase(-1)]
        public void AddZeroToNonZero(int nonZero)
        {
            Assert.AreEqual(nonZero, new Fraction(nonZero).Add(new Fraction(0)));
        }

        [Test]
        public void AddPositiveIntegers()
        {
            Assert.AreEqual(3, new Fraction(1).Add(new Fraction(2)));
        }

        [Test]
        public void AddNegativeIntegers()
        {
            Assert.AreEqual(-3, new Fraction(-1).Add(new Fraction(-2)));
        }

        [Test]
        public void AddFractionsWithDefaultDenominator()
        {
            Assert.AreEqual(7, new Fraction(5, 1).Add(new Fraction(2, 1)));
        }

        private class Fraction
        {
            private readonly int _number;
            private readonly int _denominator;

            public Fraction(int number)
            {
                _number = number;
            }

            public Fraction(int number, int denominator)
            {
                _number = number;
                _denominator = denominator;
            }

            internal int Add(Fraction fraction)
            {
                return _number + fraction._number;
            }
        }
    }
}
