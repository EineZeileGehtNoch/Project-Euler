using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Even_Fibonacci_numbers.Test
{
    [TestClass]
    public class FibunacciTest
    {
        [TestMethod]
        public void OnlyTwo()
        {
            int upperBound = 2;
            int expected = 2;
            Fibunacci fibunacci = new Fibunacci();

            int actual = fibunacci.SumEvenNumbersUpTo(upperBound);

            Assert.AreEqual(expected,actual);
        }
    }
}
