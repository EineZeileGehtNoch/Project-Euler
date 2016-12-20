using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Smallest_multiple.Test
{
    [TestClass]
    public class SmallestMultipleGeneratorTest
    {
        [TestMethod]
        public void TrivialSmallestMultiple()
        {
            List<int> numbers = new List<int> {1};
            int expected = 1;

            int actual = SmallestMultipleGenerator.GetSmallestMultipleOf(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SmallestMultipleOfPrimes()
        {
            List<int> numbers = new List<int> {2, 3, 5};
            int expected = 2*3*5;

            int actual = SmallestMultipleGenerator.GetSmallestMultipleOf(numbers);

            Assert.AreEqual(expected,actual);
        }
    }
}
