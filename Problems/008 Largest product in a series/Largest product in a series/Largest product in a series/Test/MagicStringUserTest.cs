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

        [TestMethod]
        public void BeginningOfString()
        {
            string magicString = "9911";
            int numberOfDigits = 2;
            int expected = 81;

            int actual = MagicStringUser.GetBiggestProductOfAdjacentDigits(magicString, numberOfDigits);

            Assert.AreEqual(expected,actual);
        }
    }
}
