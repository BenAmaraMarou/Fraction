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

    }
}
