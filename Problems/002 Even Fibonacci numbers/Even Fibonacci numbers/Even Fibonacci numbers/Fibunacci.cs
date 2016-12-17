using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class Fibunacci
    {
        List<int> _fibunacciNumbers;
        private int _upperBound;
        private int _indexLastFoundFibunacciNumber;
        private int _lastFoundFibunacciNumber;


        private static readonly int LOWEST_FIBUNACCI_NUMBER = 1;
        private static readonly int SECOND_TO_LOWEST_FIBUNACCI_NUMBER = 2;
        private static readonly int INDEX_WITHOUT_FIBUNACCI_NUMBERS_FOUND = -1;

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
                FillList();
            }
        }

        private bool UpperBoundNotTooLow()
        {
            return _upperBound >= LOWEST_FIBUNACCI_NUMBER;
        }

        private void FillList()
        {
            _indexLastFoundFibunacciNumber = INDEX_WITHOUT_FIBUNACCI_NUMBERS_FOUND;

            _lastFoundFibunacciNumber = LOWEST_FIBUNACCI_NUMBER;
            SaveLastFibunacciNumber();

            _lastFoundFibunacciNumber = SECOND_TO_LOWEST_FIBUNACCI_NUMBER;

            while (_lastFoundFibunacciNumber <= _upperBound)
            {
                SaveLastFibunacciNumber();
                _lastFoundFibunacciNumber = ComputeNextFibunacciNumber(_lastFoundFibunacciNumber);
            }
        }

        private void SaveLastFibunacciNumber()
        {
            _fibunacciNumbers.Add(_lastFoundFibunacciNumber);
            _indexLastFoundFibunacciNumber++;
        }

        private int ComputeNextFibunacciNumber(int lastFoundFibunacciNumber)
        {
            lastFoundFibunacciNumber = _fibunacciNumbers[_indexLastFoundFibunacciNumber - 1] +
                                       _fibunacciNumbers[_indexLastFoundFibunacciNumber];
            return lastFoundFibunacciNumber;
        }
    }
}