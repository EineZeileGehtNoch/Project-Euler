using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Special_Pythagorean_triplet.Test
{
    [TestClass]
    public class IntegerTupleTest
    {
        [TestMethod]
        public void ProductEmptyTuple()
        {
            List<int> integers = new List<int>();
            IntegerTuple integerTuple = new IntegerTuple(integers);
            int expected = 0;

            int actual = integerTuple.GetProduct();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ProductSingleTuple()
        {
            List<int> integers = new List<int>{1};
            IntegerTuple integerTuple = new IntegerTuple(integers);
            int expected = 1;

            int actual = integerTuple.GetProduct();

            Assert.AreEqual(expected,actual);
        }
    }

}
