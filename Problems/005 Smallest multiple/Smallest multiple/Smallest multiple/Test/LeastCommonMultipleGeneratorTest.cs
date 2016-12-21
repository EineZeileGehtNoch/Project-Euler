using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Smallest_multiple.Test
{
    [TestClass]
    public class LeastCommonMultipleGeneratorTest
    {
        [TestMethod]
        public void TrivialSmallestMultiple()
        {
            List<int> numbers = new List<int> {1};
            int expected = 1;

            int actual = LeastCommonMultipleGenerator.GetLCMOf(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SmallestMultipleOfPrimes()
        {
            List<int> numbers = new List<int> { 2, 3, 5 };
            int expected = 2 * 3 * 5;

            int actual = LeastCommonMultipleGenerator.GetLCMOf(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LeastCommonMultipleOfSameNumber()
        {
            List<int> numbers = new List<int> {2, 2};
            int expected = 2;

            int actual = LeastCommonMultipleGenerator.GetLCMOf(numbers);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void LeastCommonMultipleOfNonPrime()
        {
            List<int> numbers = new List<int> { 4 };
            int expected = 4;

            int actual = LeastCommonMultipleGenerator.GetLCMOf(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BigLeastCommonMultiple()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int expected = 2520;

            int actual = LeastCommonMultipleGenerator.GetLCMOf(numbers);

            Assert.AreEqual(expected, actual);
        }
    }
}
