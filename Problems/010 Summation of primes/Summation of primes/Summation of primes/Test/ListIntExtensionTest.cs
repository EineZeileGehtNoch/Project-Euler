using System;
using System.Collections.Generic;
using System.Linq;
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
        public void ProductOfSomeFactors()
        {
            List<int> factors = new List<int> {2, 3, 4};
            int expected = 2*3*4;

            int actual = factors.Product();

            Assert.AreEqual(expected,actual);
        }
    }
}
