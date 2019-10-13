using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class MultiplyTest
    {
        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(0)]
        public void Zero(int number)
        {
            Assert.AreEqual(new Fraction(0), new Fraction(number).Multiply(new Fraction(0)));
        }

        [TestCase(5)]
        [TestCase(-5)]
        [TestCase(1)]
        public void One(int number)
        {
            Assert.AreEqual(new Fraction(number), new Fraction(number).Multiply(new Fraction(1)));
        }

        [Test]
        public void PositiveFractions()
        {
            Assert.AreEqual(new Fraction(35, 6), new Fraction(5, 2).Multiply(new Fraction(7, 3)));
        }

        [Test]
        public void NegativeFractions()
        {
            Assert.AreEqual(new Fraction(2, 21), new Fraction(1, -3).Multiply(new Fraction(-2, 7)));
        }

        [Test]
        public void ReduceToOne()
        {
            Assert.AreEqual(new Fraction(1), new Fraction(3).Multiply(new Fraction(1, 3)));
        }

        [Test]
        public void Reduce()
        {
            Assert.AreEqual(new Fraction(2, 3), new Fraction(3, 7).Multiply(new Fraction(14, 9)));
        }
    }
}
