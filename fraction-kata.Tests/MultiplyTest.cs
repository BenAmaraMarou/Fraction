using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class MultiplyTest
    {
        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(0)]
        public void MultiplyZero(int number)
        {
            Assert.AreEqual(new Fraction(0), new Fraction(number).Multiply(new Fraction(0)));
        }

        [TestCase(5)]
        [TestCase(-5)]
        [TestCase(1)]
        public void MultiplyOne(int number)
        {
            Assert.AreEqual(new Fraction(number), new Fraction(number).Multiply(new Fraction(1)));
        }

        [Test]
        public void MultiplyFractions()
        {
            Assert.AreEqual(new Fraction(35, 6), new Fraction(5, 2).Multiply(new Fraction(7, 3)));
        }

        [Test]
        public void MultiplyNegativeFractions()
        {
            Assert.AreEqual(new Fraction(2, 21), new Fraction(1, -3).Multiply(new Fraction(-2, 7)));
        }

    }
}
