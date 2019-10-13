using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class SubstractFraction
    {
        [TestCase(0)]
        [TestCase(1)]
        public void SubstractZero(int number)
        {
            Assert.AreEqual(new Fraction(number), new Fraction(number).Substract(new Fraction(0)));
        }






    }
}
