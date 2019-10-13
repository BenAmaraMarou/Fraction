using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class DivideFractionTest
    {
        [Test]
        public void ZeroNumerator()
        {
            Assert.AreEqual(new Fraction(0), new Fraction(0).Divide(new Fraction(5)));
        }
    }
}
