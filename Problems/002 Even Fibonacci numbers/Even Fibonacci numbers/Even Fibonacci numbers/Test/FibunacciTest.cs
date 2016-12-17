using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Even_Fibonacci_numbers.Test
{
    [TestClass]
    public class FibunacciTest
    {
        [TestMethod]
        public void FibunacciNumbersUpTonNinety()
        {
            int upperBound = 90;
            Fibunacci fibunacci = new Fibunacci();
            List<int> expected = new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

            List<int> actual = fibunacci.GetFibunacciNumbersUpTo(upperBound);

            Assert.AreEqual(expected,actual);
        }
    }
}
