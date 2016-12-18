using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Smallest_multiple.Test
{
    [TestClass]
    public class PrimeFactorGeneratorTest
    {
        [TestMethod]
        public void NoPrimeFactors()
        {
            int number = 1;
            List<int> expected = new List<int>();

            List<int> actual = PrimeFactorGenerator.GetNumberOfPrimeFactors();

            CollectionAssert.AreEqual(expected,actual);
        }
    }
}
