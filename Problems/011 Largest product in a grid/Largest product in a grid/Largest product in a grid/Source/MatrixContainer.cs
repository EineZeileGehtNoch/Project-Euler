using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_product_in_a_grid.Source
{
    class MatrixContainer
    {
        enum Direction
        {
            Down,
            Right,
            DiagonalDownAndRight,
            DiagonalDownAndLeft
        }

        private readonly int[,] _matrix;

        private int _numberOfFactors;

        private int _biggestProduct;

        private const int DEFAULT_PRODUCT = -1;

        public MatrixContainer(int[,] matrix)
        {
            _matrix = matrix;
        }

        public int GetLargestProduct(int numberOfFactors)
        {
            _numberOfFactors = numberOfFactors;

            _biggestProduct = DEFAULT_PRODUCT;

            foreach (Direction direction in Enum.GetValues(typeof(Direction)) )
            {
                for (int row = MinRow(direction); row <= MaxRow(direction); row++)
                {
                    for (int column = MinColumn(direction); column <= MaxColumn(direction); column++)
                    {
                        int product = GetProduct(row, column, direction);

                        IfBiggerSetAsNewBiggestProduct(product);
                    }
                }
            }

            return _biggestProduct;
        }

        private int GetProduct(int startingRow, int startingColumn, Direction direction)
        {
            int product = 1;
            int row = startingRow;
            int column = startingColumn;

            for (int i = 0; i < _numberOfFactors; i++)
            {
                product *= _matrix[row,column];
                row += IncrementForRow(direction);
                column += IncrementForColumn(direction);
            }

            return product;
        }

        private static int IncrementForColumn(Direction direction)
        {
            if (GoesRight(direction))
            {
                return 1;
            }
            if (GoesLeft(direction))
            {
                return -1;
            }
            return 0;
        }

        private static bool GoesLeft(Direction direction)
        {
            if (direction==Direction.DiagonalDownAndLeft)
            {
                return true;
            }
            return false;
        }

        private static int IncrementForRow(Direction direction)
        {
            if (GoesDown(direction))
            {
                return 1;
            }
            return 0;
        }

        private void IfBiggerSetAsNewBiggestProduct(int product)
        {
            if (IsBiggerThanLastFoundBiggestProduct(product))
            {
                SetAsNewBiggestProduct(product);
            }
        }

        private void SetAsNewBiggestProduct(int product)
        {
            _biggestProduct = product;
        }

        private bool IsBiggerThanLastFoundBiggestProduct(int product)
        {
            return product>_biggestProduct;
        }

        private int MinRow(Direction direction)
        {
            int minrow = 0;
            if (direction)
            {
                
            }
        }

        private int MaxColumn(Direction direction)
        {
            int maxColumn = _matrix.GetLength(1)-1;
            if (GoesRight(direction))
            {
                maxColumn -= _numberOfFactors-1;
            }

            return maxColumn;
        }

        private static bool GoesRight(Direction direction)
        {
            return direction==Direction.Right||direction==Direction.DiagonalDownAndRight;
        }

        private int MaxRow(Direction direction)
        {
            int maxRow = _matrix.GetLength(0)-1;
            if (GoesDown(direction))
            {
                maxRow -= _numberOfFactors-1;
            }

            return maxRow;
        }

        private static bool GoesDown(Direction direction)
        {
            return direction==Direction.Down||direction==Direction.DiagonalDownAndRight;
        }
    }
}
