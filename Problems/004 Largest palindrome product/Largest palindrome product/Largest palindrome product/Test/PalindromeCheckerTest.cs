using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largest_palindrome_product.Test
{
    [TestClass]
    public class PalindromeCheckerTest
    {

        [TestMethod]
        public void SmallestPalindrome()
        {
            int number = 1;

            bool actual = PalindromeChecker.NumberIsPalindrome(number);

            Assert.AreEqual(true,actual);
        }

        [TestMethod]
        public void SmallestNonPalindrome()
        {
            int number = 12;

            bool actual = PalindromeChecker.NumberIsPalindrome(number);

            Assert.AreEqual(false,actual);
        }
    }
}
