using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class FractionTests
    {
        [TestCase(1)]
        [TestCase(-1)]
        public void AddZeroToNonZero(int nonZero)
        {
            Fraction actual = new Fraction(nonZero).Add(new Fraction(0));
            Assert.AreEqual(nonZero, actual.Numerator());
        }

        [Test]
        public void AddPositiveIntegers()
        {
            Fraction actual = new Fraction(1).Add(new Fraction(2));
            Assert.AreEqual(3, actual.Numerator());
        }

        [Test]
        public void AddNegativeIntegers()
        {
            Fraction actual = new Fraction(-1).Add(new Fraction(-2));
            Assert.AreEqual(-3, actual.Numerator());
        }

        [Test]
        public void AddFractionsWithDefaultDenominator()
        {
            Fraction actual = new Fraction(5, 1).Add(new Fraction(2, 1));
            Assert.AreEqual(7, actual.Numerator());
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
            
            internal Fraction Add(Fraction fraction)
            {
                return new Fraction(_number + fraction._number);
            }

            internal double Numerator()
            {
                return _number;
            }
        }
    }
}
