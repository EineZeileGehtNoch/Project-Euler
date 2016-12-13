using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Even_Fibonacci_numbers.Test
{
    [TestClass]
    public class NumberAdderTest
    {
        [TestMethod]
        public void OnlyAOne()
        {
            int expected = 0;
            List<int> onlyOne = new List<int> {1};

            int actual = NumberAdder.SumOfEvenNumbers(onlyOne);

            Assert.AreEqual(expected, actual);
        }
    }
}
