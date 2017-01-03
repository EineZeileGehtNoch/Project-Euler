using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Special_Pythagorean_triplet.Test
{
    [TestClass]
    public class PythagoreanTest
    {
        [TestMethod]
        public void SumOfTwelve()
        {
            int sum = 12;
            IntegerTuple triplet = Pythagorean.GetTripletWithSumOf(sum);
            List<int> expected = new List<int>{3,4,5};

            List<int> actual = triplet.ToList();


            CollectionAssert.AreEqual(expected,actual);
        }
    }
}
