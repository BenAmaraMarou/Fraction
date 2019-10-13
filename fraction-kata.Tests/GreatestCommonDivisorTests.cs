using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class GreatestCommonDivisorTests
    {
        [Test]
        public void SameNumbers()
        {
            Assert.AreEqual(1, Gcd(1, 1));
            Assert.AreEqual(2, Gcd(2, 2));
            Assert.AreEqual(-1, Gcd(-1, -1));
        }

        [Test]
        public void NumbersWithNoCommonFactors()
        {
            Assert.AreEqual(1, Gcd(2, 5));
            Assert.AreEqual(1, Gcd(3, 7));
            Assert.AreEqual(-1, Gcd(-2, -3));
        }
        
        [Test]
        public void OneMulptipleOfOther()
        {
            Assert.AreEqual(3, Gcd(3, 6));
            Assert.AreEqual(2, Gcd(10, 12));
            Assert.AreEqual(5, Gcd(5, 30));
        }

        private int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

    }
}
