using System.Reflection.Emit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largest_Prime_Number.Tests
{
    [TestClass]
    public class PrimeFactoryTest
    {
        [TestMethod]
        public void LargestPrimeFactorOfTwo()
        {
            int numberToFactor = 2;
            int expected = 2;

            int actual = PrimeFactory.GetHighestPrime(numberToFactor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LargestPrimeFactorOfSix()
        {
            int numberToFactor = 2*3;
            int expected = 3;

            int actual = PrimeFactory.GetHighestPrime(numberToFactor);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void LargestPrimeFactorOfLargeNumber()
        {
            int numberToFactor = 13195;
            int expected = 29;

            int actual = PrimeFactory.GetHighestPrime(numberToFactor);

            Assert.AreEqual(expected,actual);
        }
    }
}
