using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sum_square_difference.Test
{
    [TestClass]
    public class SumAndSquareTest
    {
        [TestMethod]
        public void TivialDifference()
        {
            int upperBound = 0;
            int expected = 0;

            int actual = SumAndSquare.DifferenceBetweenDifferentOrder(upperBound);

            Assert.AreEqual(expected,actual);
        }
    }
}
