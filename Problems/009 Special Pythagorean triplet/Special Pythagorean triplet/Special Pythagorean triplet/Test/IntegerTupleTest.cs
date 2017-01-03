using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Special_Pythagorean_triplet.Test
{
    [TestClass]
    public class IntegerTupleTest
    {
        [TestMethod]
        public void ProductEmptyTuple()
        {
            IntegerTuple integerTuple = new IntegerTuple();
            int expected = 1;

            int actual = integerTuple.GetProduct();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void ProductSingleTuple()
        {
            IntegerTuple integerTuple = new IntegerTuple(1);
            int expected = 1;

            int actual = integerTuple.GetProduct();

            Assert.AreEqual(expected,actual);
        }

        
    }

}
