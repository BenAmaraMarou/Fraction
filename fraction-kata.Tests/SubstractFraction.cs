using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class SubstractFraction
    {
        [TestCase(0)]
        [TestCase(1)]
        public void SubstractZero(int number)
        {
            Assert.AreEqual(new Fraction(number), new Fraction(number).Substract(new Fraction(0)));
        }
        
        [Test]
        public void SubstractIntegers()
        {
            Assert.AreEqual(new Fraction(2), new Fraction(3).Substract(new Fraction(1)));
        }

        [Test]
        public void SubstractNegativeIntegers()
        {
            Assert.AreEqual(new Fraction(1), new Fraction(-1).Substract(new Fraction(-2)));
        }
        
        [Test]
        public void SubstractFractionsWithSameDenominator()
        {
            Assert.AreEqual(new Fraction(1, 3), new Fraction(2, 3).Substract(new Fraction(1, 3)));
        }
    }
}
