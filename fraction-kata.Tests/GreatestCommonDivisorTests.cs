using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class GreatestCommonDivisorTests
    {
        [Test]
        public void GcdOfOneAndOneIsOne()
        {
            Assert.AreEqual(1, Gcd(1, 1));
        }

        internal int Gcd(int a, int b)
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
