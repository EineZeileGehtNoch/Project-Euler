using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largest_palindrome_product.Test
{
    [TestClass]
    public class PalindromeTest
    {

        [TestMethod]
        public void TrivialPalindrome()
        {
            int number = 1;
            bool expected = true;

            bool actual = Palindrome.NumberIsPalindrome(number);

            Assert.AreEqual(expected,actual);
        }

    }
}
