using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class MultiplyTest
    {

        [Test]
        public void MultiplyZero()
        {
            Assert.AreEqual(new Fraction(0), new Fraction(5).Multiply(new Fraction(0)));
        }

    }
}
