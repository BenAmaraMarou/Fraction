using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class MultiplyTest
    {

        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(0)]
        public void MultiplyZero(int nonZero)
        {
            Assert.AreEqual(new Fraction(0), new Fraction(nonZero).Multiply(new Fraction(0)));
        }

        [Test]
        public void MultiplyOne()
        {
            Assert.AreEqual(new Fraction(5), new Fraction(5).Multiply(new Fraction(1)));
        }

    }
}
