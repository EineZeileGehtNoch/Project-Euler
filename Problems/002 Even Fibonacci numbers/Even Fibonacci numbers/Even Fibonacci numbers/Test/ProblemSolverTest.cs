using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Even_Fibonacci_numbers.Test
{
    [TestClass]
    public class ProblemSolverTest
    {
        [TestMethod]
        public void OnlyTwo()
        {
            int upperBound = 2;
            int expected = 2;
            ProblemSolver problemSolver = new ProblemSolver();

            int actual = problemSolver.SumEvenOfEvenFibunacciNumbersUpTo(upperBound);

            Assert.AreEqual(expected,actual);
        }
    }
}
