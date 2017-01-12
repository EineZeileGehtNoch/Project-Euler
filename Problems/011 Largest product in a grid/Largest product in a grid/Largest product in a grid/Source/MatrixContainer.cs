using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_product_in_a_grid.Source
{
    class MatrixContainer
    {
        private int[][] _matrix;

        enum Directions
        {
            Down=0x10,
            Right=0x01,
            DiagonalDownAndRight=0x11
        }

        public MatrixContainer(int[][] matrix)
        {
            _matrix = matrix;
        }

        public int GetLargestProduct(int numberOfFactors)
        {
            return 0;
        }

    }
}
