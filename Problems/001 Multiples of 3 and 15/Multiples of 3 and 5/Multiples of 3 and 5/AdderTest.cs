using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Multiples_of_3_and_5
{
    [TestClass]
    public class AdderTest
    {
        [TestMethod]
        public void TrivalFactor()
        {
            int upperBound = 10;
            List<int> factor = new List<int> {1};
            int expected = 45;

            int actual = Adder.SumOfNumbersBelowDivisibleByAnyFactor(upperBound, factor);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void NoFactors()
        {
            int upperBound = 10;
            List<int> factor = new List<int>();
            int expected = 0;

            int actual = Adder.SumOfNumbersBelowDivisibleByAnyFactor(upperBound, factor);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void SumOfNumbersBelowFifteenDivisibleByThreeOrFive()
        {
            int upperBound = 10;
            List<int> factors = new List<int> {3, 5};
            int expected = 23;

            int actual = Adder.SumOfNumbersBelowDivisibleByAnyFactor(upperBound, factors);

            Assert.AreEqual(expected,actual);
        }
    }
}
