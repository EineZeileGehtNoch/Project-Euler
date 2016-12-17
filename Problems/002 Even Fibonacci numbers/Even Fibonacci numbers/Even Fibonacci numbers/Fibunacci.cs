using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class Fibunacci
    {
        List<int> _fibunacciNumbers;
        private int _upperBound;
        private int _indexLastFoundFibunacciNumber;

        private static readonly int LOWEST_FIBUNACCI_NUMBER=1;
        private static readonly int SECOND_TO_LOWEST_FIBUNACCI_NUMBER = 2;

        public List<int> GetFibunacciNumbersUpTo(int upperBound)
        {
            _upperBound = upperBound;

            CreateEmptyList();
            FillListIfUpperBoundNotTooLow();

            return _fibunacciNumbers;
        }

        private void CreateEmptyList()
        {
            _fibunacciNumbers = new List<int>();
        }

        private void FillListIfUpperBoundNotTooLow()
        {
            if (UpperBoundNotTooLow())
            {
                ComputeFibunacciNumbers();
            }
        }

        private void ComputeFibunacciNumbers()
        {
            int lastFoundFibunacciNumber = LOWEST_FIBUNACCI_NUMBER;

            _fibunacciNumbers.Add(lastFoundFibunacciNumber);

            lastFoundFibunacciNumber = SECOND_TO_LOWEST_FIBUNACCI_NUMBER;

            _indexLastFoundFibunacciNumber = 0;
            while (lastFoundFibunacciNumber <= _upperBound)
            {
                _fibunacciNumbers.Add(lastFoundFibunacciNumber);
                _indexLastFoundFibunacciNumber++;
                lastFoundFibunacciNumber = _fibunacciNumbers[_indexLastFoundFibunacciNumber - 1] +
                                           _fibunacciNumbers[_indexLastFoundFibunacciNumber];
            }
        }

        private bool UpperBoundNotTooLow()
        {
            return _upperBound>=LOWEST_FIBUNACCI_NUMBER;
        }
    }
}