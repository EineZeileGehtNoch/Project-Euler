﻿using Largest_product_in_a_grid.Source;
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
    }
}
