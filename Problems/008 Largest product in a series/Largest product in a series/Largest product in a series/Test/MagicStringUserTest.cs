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

            int actual = MagicStringUser.GetBiggestProductOfAdjacentDigits(numberOfDigits);
            
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void QuadroDigit()
        {
            int numberOfDigits = 4;
            int expected = 5832;

            int actual = MagicStringUser.GetBiggestProductOfAdjacentDigits(numberOfDigits);

            Assert.AreEqual(expected,actual);
        }
    }
}
