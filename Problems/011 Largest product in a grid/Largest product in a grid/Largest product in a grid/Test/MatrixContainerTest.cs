using Largest_product_in_a_grid.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largest_product_in_a_grid.Test
{
    [TestClass]
    public class MatrixContainerTest
    {
        [TestMethod]
        public void SingleNumber()
        {
            int numberOfFactors = 1;
            int[][] matrix = new int[1][];
            matrix[0]= new int[]{9};
            MatrixContainer matrixContainer = new MatrixContainer(matrix);
            int expected = 9;

            int actual = matrixContainer.GetLargestProduct(numberOfFactors);

            Assert.AreEqual(expected,actual);
        }


        [TestMethod]
        public void DoubleNumberFirstRow()
        {
            int numberOfFactors = 2;
            int[][] matrix = new int[2][];
            matrix[0] = new int[] {2, 2};
            matrix[1] = new int[] {1, 1};
            MatrixContainer matrixContainer = new MatrixContainer(matrix);
            int expected = 2*2;

            int actual = matrixContainer.GetLargestProduct(numberOfFactors);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void DoubleNumberSecondRow()
        {
            int numberOfFactors = 2;
            int[][] matrix = new int[2][];
            matrix[0] = new int[] { 1, 1 };
            matrix[1] = new int[] { 2, 2 };
            MatrixContainer matrixContainer = new MatrixContainer(matrix);
            int expected = 2 * 2;

            int actual = matrixContainer.GetLargestProduct(numberOfFactors);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void SingleNumberInMagicMatrix()
        {
            int numberOfFactors = 1;
            int[][] matrix = MagicStringContainer.GetIntegerMatrix();
            MatrixContainer matrixContainer = new MatrixContainer(matrix);
            int expected = 99;

            int actual = matrixContainer.GetLargestProduct(numberOfFactors);

            Assert.AreEqual(expected,actual);
        }
    }
}
