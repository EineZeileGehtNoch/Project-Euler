using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Summation_of_primes.Test
{
    [TestClass]
    public class ListIntExtensionTest
    {
        [TestMethod]
        public void ProductOfSomeSummands()
        {
            List<int> summands = new List<int> {2, 3, 4};
            BigInteger expected = 2+3+4;

            BigInteger actual = summands.Sum();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void SumOfBigSummands()
        {
            List<int> summands = new List<int>{Int32.MaxValue, Int32.MaxValue        };
            BigInteger expected = new BigInteger(Int32.MaxValue) +new BigInteger(Int32.MaxValue);

            BigInteger actual = summands.Sum();

            Assert.AreEqual(expected,actual);
        }
    }
}
