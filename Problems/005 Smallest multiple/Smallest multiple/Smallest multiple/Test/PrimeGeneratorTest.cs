using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Smallest_multiple.Test
{
    [TestClass]
    public class PrimeGeneratorTest
    {
        [TestMethod]
        public void GetFirstPrime()
        {
            PrimeGenerator primeGenerator = new PrimeGenerator();
            int expected = 2;

            int actual = primeGenerator.GetFirstOrNextPrime();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void GetSecondPrime()
        {
            PrimeGenerator primeGenerator = new PrimeGenerator();
            int expected = 3;

            primeGenerator.GetFirstOrNextPrime();
            int actual = primeGenerator.GetFirstOrNextPrime();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void GetThirdPrime()
        {
            PrimeGenerator primeGenerator = new PrimeGenerator();
            int expected = 5;

            primeGenerator.GetFirstOrNextPrime();
            primeGenerator.GetFirstOrNextPrime();
            int actual = primeGenerator.GetFirstOrNextPrime();

            Assert.AreEqual(expected,actual);
        }
    }
}
