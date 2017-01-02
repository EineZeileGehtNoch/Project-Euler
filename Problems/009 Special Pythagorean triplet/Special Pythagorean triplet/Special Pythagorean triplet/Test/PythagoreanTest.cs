using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Special_Pythagorean_triplet.Test
{
    [TestClass]
    class PythagoreanTest
    {
        [TestMethod]
        public void SumOfTwelve()
        {
            int sum = 12;
            List<int> integerList = new List<int>{3,4,5};
            IntegerTuple expected = new IntegerTuple(integerList);

            IntegerTuple actual = Pythagorean.GetSmallestTripletWithSumOf(sum);

            Assert.AreEqual(expected,actual);
        }
    }
}
