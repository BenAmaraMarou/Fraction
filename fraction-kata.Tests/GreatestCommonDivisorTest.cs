using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class GreatestCommonDivisorTest
    {
        [Test]
        public void SameNumbers()
        {
            Assert.AreEqual(1, GeatestCommonDivisor.Gcd(1, 1));
            Assert.AreEqual(2, GeatestCommonDivisor.Gcd(2, 2));
            Assert.AreEqual(1, GeatestCommonDivisor.Gcd(-1, -1));
        }

        [Test]
        public void NumbersWithNoCommonFactor()
        {
            Assert.AreEqual(1, GeatestCommonDivisor.Gcd(2, 5));
            Assert.AreEqual(1, GeatestCommonDivisor.Gcd(3, 7));
            Assert.AreEqual(1, GeatestCommonDivisor.Gcd(-2, -3));
        }
        
        [Test]
        public void OneMulptipleOfOther()
        {
            Assert.AreEqual(3, GeatestCommonDivisor.Gcd(3, 6));
            Assert.AreEqual(2, GeatestCommonDivisor.Gcd(10, 12));
            Assert.AreEqual(5, GeatestCommonDivisor.Gcd(5, 30));
        }

        [Test]
        public void NumbersWithCommonFactor()
        {
            Assert.AreEqual(2, GeatestCommonDivisor.Gcd(6, 8));
            Assert.AreEqual(21, GeatestCommonDivisor.Gcd(63, 147));
            Assert.AreEqual(15, GeatestCommonDivisor.Gcd(-105, -150));
        }

        [Test]
        public void NegativeNumbers()
        {
            Assert.AreEqual(4, GeatestCommonDivisor.Gcd(-28, -32));
            Assert.AreEqual(4, GeatestCommonDivisor.Gcd(-28, 32));
            Assert.AreEqual(4, GeatestCommonDivisor.Gcd(28, -32));
        }
    }
}
