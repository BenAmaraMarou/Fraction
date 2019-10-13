using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class DivideFractionTest
    {
        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(5)]
        public void ZeroNumerator(int nonZero)
        {
            Assert.AreEqual(new Fraction(0), new Fraction(0).Divide(new Fraction(nonZero)));
        }
    }
}
