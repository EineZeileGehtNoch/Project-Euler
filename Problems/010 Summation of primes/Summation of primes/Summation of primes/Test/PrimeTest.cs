using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Summation_of_primes.Test
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void GetFirstPrime()
        {
            int numberOfPrimes = 1;
            List<int> expected = new List<int>{2};

            List<int> actual = Prime.GetFirstNPrimes(numberOfPrimes);

            CollectionAssert.AreEqual(expected,actual);
        }
    }
}
