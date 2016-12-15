using System;
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
            long numberToFactor = 2;
            long expected = 2;

            long actual = PrimeFactory.GetHighestPrime(numberToFactor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LargestPrimeFactorOfSix()
        {
            long numberToFactor = 2*3;
            long expected = 3;

            long actual = PrimeFactory.GetHighestPrime(numberToFactor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LargestPrimeFactorOfLargeNumber()
        {
            long numberToFactor = 13195;
            long expected = 29;

            long actual = PrimeFactory.GetHighestPrime(numberToFactor);

            Assert.AreEqual(expected, actual);
        }
    }
}
