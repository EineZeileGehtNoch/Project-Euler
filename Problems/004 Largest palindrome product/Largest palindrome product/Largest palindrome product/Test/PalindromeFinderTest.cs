using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largest_palindrome_product.Test
{
    [TestClass]
    public class PalindromeFinderTest
    {
        [TestMethod]
        public void BiggestPalindromeOutOfSingleDigitFactors()
        {
            int numberOfDigits = 1;
            int expected = 3*3;

            int actual = PalindromeFinder.GetLargestPalindromeWhichIsProdukt(numberOfDigits);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void BiggestPalindromeOutOfDoubleDigitFactors()
        {
            int numberOfDigits = 2;
            int expected = 91*99;

            int actual = PalindromeFinder.GetLargestPalindromeWhichIsProdukt(numberOfDigits);

            Assert.AreEqual(expected,actual);
        }
    }
}
