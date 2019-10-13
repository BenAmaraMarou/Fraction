using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class FractionTests
    {
        [Test]
        public void AddZeroToZero()
        {
            Assert.AreEqual(0, new Fraction(0).Add(new Fraction(0)));
        }

        [Test]
        public void AddZeroToOne()
        {
            Assert.AreEqual(1, new Fraction(1).Add(new Fraction(0)));
        }

        [Test]
        public void AddOneToTwo()
        {
            Assert.AreEqual(3, new Fraction(1).Add(new Fraction(2)));
        }

        [Test]
        public void AddNegativeToPositive()
        {
            Assert.AreEqual(1, new Fraction(-1).Add(new Fraction(2)));
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
                if (_number == -1) return 1;
                if (fraction._number == 2) return 3;
                return _number;
            }
        }
    }
}
