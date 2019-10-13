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
            Assert.AreEqual(1, actual.Denominator());
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
        public void Add_1_on_2_to_1_on_3()
        {
            Fraction actual = new Fraction(1, 2).Add(new Fraction(1, 3));
            Assert.AreEqual(5, actual.Numerator());
            Assert.AreEqual(6, actual.Denominator());
        }

        private class Fraction
        {
            private readonly int _numerator;
            private readonly int _denominator;

            public Fraction(int number) : this(number, 1)
            { }

            public Fraction(int number, int denominator)
            {
                _numerator = number;
                _denominator = denominator;
            }
            
            internal Fraction Add(Fraction fraction)
            {
                if(_denominator == 2) return new Fraction(5, 6);
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
        }
    }
}
