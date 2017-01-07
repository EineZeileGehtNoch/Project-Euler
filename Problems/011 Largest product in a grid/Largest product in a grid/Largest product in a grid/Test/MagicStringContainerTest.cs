using System.Collections.Generic;
using Largest_product_in_a_grid.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largest_product_in_a_grid.Test
{
    [TestClass]
    public class MagicStringContainerTest
    {
        [TestMethod]
        public void FirstInteger()
        {
            List<List<int>> integers = MagicStringContainer.GetAsIntegers();
            int expected = 8;

            int actual = integers[0][0];

            Assert.AreEqual(expected,actual);
        }
    }
}
