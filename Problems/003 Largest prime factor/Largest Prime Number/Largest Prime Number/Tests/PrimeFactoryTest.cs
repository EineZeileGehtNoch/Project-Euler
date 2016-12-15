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

            Assert.AreEqual(expected,actual);
        }
    }
}
