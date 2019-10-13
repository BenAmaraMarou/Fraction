using NUnit.Framework;

namespace fraction_kata.Tests
{
    public class SubstractFraction
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void SubstractZero(int number)
        {
            Assert.AreEqual(new Fraction(number), new Fraction(number).Substract(new Fraction(0)));
        }
        
        [TestCase(1 ,3)]
        [TestCase(-1 , 3)]
        [TestCase(1 , -3)]
        [TestCase(-1 , -3)]
        public void SubstractNonZero(int first, int second)
        {
            Assert.AreEqual(new Fraction(first - second), new Fraction(first).Substract(new Fraction(second)));
        }
        
        [Test]
        public void FractionsWithSameDenominator()
        {
            Assert.AreEqual(new Fraction(1, 3), new Fraction(2, 3).Substract(new Fraction(1, 3)));
        }
        
        [Test]
        public void FractionsWithDifferentDenominators()
        {
            Assert.AreEqual(new Fraction(1, 6), new Fraction(1, 2).Substract(new Fraction(1, 3)));
        }

        [Test]
        public void NegativeFractions()
        {
            Assert.AreEqual(new Fraction(-1, 6), new Fraction(-1, 2).Substract(new Fraction(-1, 3)));
        }
               
        [Test]
        public void NegativeFractionsOnDenominator()
        {
            Assert.AreEqual(new Fraction(-1, 6), new Fraction(1, -2).Substract(new Fraction(1, -3)));
        }
        
        [Test]
        public void ReduceSameDenominator()
        {
            Assert.AreEqual(new Fraction(2, 5), new Fraction(3, 5).Substract(new Fraction(1, 5)));
        }

        [Test]
        public void ReduceToOne()
        {
            Assert.AreEqual(new Fraction(1), new Fraction(3, 2).Substract(new Fraction(1, 2)));
        }

        [Test]
        public void ReduceFractionsWithMultipleDenominators()
        {
            Assert.AreEqual(new Fraction(1, 8), new Fraction(3, 4).Substract(new Fraction(5, 8)));
        }

        [Test]
        public void ReduceFractionsWithNonMultipleDenominators()
        {
            Assert.AreEqual(new Fraction(-5, 6), new Fraction(2, 3).Substract(new Fraction(6, 4)));
        }
    }
}
