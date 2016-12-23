using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10001st_prime.Test
{
    [TestClass]
    public class PrimeGeneratorTest
    {
        [TestMethod]
        public void SmallestPrime()
        {
            int numberOfPrime = 1;
            int expected = 2;

            int actual = PrimeGenerator.GetNthPrime(numberOfPrime);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void SomePrime()
        {
            int numberOfPrime = 6;
            int expected = 13;

            int actual = PrimeGenerator.GetNthPrime(numberOfPrime);

            Assert.AreEqual(expected,actual);
        }
    }
}
