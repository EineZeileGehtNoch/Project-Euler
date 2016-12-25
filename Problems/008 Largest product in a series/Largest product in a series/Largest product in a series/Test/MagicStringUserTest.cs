using System.Numerics;
using System.Security;
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

            BigInteger actual = MagicStringUser.GetBiggestProductOfAdjacentDigits(numberOfDigits);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuadroDigit()
        {
            int numberOfDigits = 4;
            int expected = 5832;

            BigInteger actual = MagicStringUser.GetBiggestProductOfAdjacentDigits(numberOfDigits);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BeginningOfString()
        {
            string magicString = "7819";
            int numberOfDigits = 2;
            int expected = 7*8;

            BigInteger actual = MagicStringUser.GetBiggestProductOfAdjacentDigits(magicString, numberOfDigits);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EndOfString()
        {
            string magicString = "9187";
            int numberOfDigits = 2;
            int expected = 8*7;

            BigInteger actual = MagicStringUser.GetBiggestProductOfAdjacentDigits(magicString, numberOfDigits);

            Assert.AreEqual(expected,actual);
        }
    }
}
