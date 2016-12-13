using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Even_Fibonacci_numbers.Test
{
    [TestClass]
    public class NumberAdderTest
    {
        [TestMethod]
        public void OnlyUneven()
        {
            int expected = 0;
            List<int> onlyOne = new List<int> {1};

            int actual = NumberAdder.SumOfEvenNumbers(onlyOne);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OnlyEven()
        {
            int expected = 42;
            List<int> onlyEven = new List<int>{40,2};

            int actual = NumberAdder.SumOfEvenNumbers(onlyEven);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullListSumOfEvenNumbers()
        {
            int actual = NumberAdder.SumOfEvenNumbers(null);

            Assert.Fail();
        }

        
    }
}
