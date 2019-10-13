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

        private class Fraction
        {
            private readonly int _number;

            public Fraction(int number)
            {
                _number = number;
            }

            internal int Add(Fraction fraction)
            {
                return _number + fraction._number;
            }
        }
    }
}
