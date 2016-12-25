using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largest_product_in_a_series.Test
{
    [TestClass]
    public class MagicStringUserTest
    {
        [TestMethod]
        public void SingleDigit()
        {
            int numberOfDigits = 1;
            int expected = 9;

            int actual = MagicStringUser.GetBiggestProduct(numberOfDigits);
            
            Assert.AreEqual(expected,actual);
        }
    }
}
