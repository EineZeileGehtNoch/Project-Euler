using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Multiples_of_3_and_5
{
    [TestClass]
    public class AdderTest
    {
        [TestMethod]
        public void TrivalFactor()
        {
            int numberToFactor = 10;
            List<int> factor = new List<int> {1};
            int expected = 45;

            int actual = Adder.SumOfNumbersBelowDivisibleByAnyFactor(numberToFactor, factor);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void NoFactors()
        {
            int numberToFactor = 10;
            List<int> factor = new List<int>();
            int expected = 0;

            int actual = Adder.SumOfNumbersBelowDivisibleByAnyFactor(numberToFactor, factor);

            Assert.AreEqual(expected,actual);
        }
    }
}
