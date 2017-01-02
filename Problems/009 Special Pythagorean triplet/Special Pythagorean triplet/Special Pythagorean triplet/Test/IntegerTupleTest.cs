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
            IntegerTuple integegTuple = new IntegerTuple(integers);
            int expected = 0;

            int actual = integegTuple.GetProduct();

            Assert.AreEqual(expected,actual);
        }
    }
}
