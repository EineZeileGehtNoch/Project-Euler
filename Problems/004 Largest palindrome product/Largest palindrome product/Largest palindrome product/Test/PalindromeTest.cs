using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largest_palindrome_product.Test
{
    [TestClass]
    public class PalindromeTest
    {

        [TestMethod]
        public void SmallestPalindrome()
        {
            int number = 1;

            bool actual = Palindrome.NumberIsPalindrome(number);

            Assert.AreEqual(true,actual);
        }

        [TestMethod]
        public void SmallestNonPalindrome()
        {
            int number = 12;

            bool actual = Palindrome.NumberIsPalindrome(number);

            Assert.AreEqual(false,actual);
        }
    }
}
