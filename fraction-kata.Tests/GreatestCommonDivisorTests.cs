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
