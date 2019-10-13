using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class SubstractFraction
    {
        [Test]
        public void SubstractZero()
        {
            Assert.AreEqual(new Fraction(0), new Fraction(0).Substract(new Fraction(0)));
        }

    }
}
