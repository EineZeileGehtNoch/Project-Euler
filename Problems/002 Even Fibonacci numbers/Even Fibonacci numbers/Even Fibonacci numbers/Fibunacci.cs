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
            SetDefaultIndex();

            ComputeAndSaveFirstFibunacciNumber();

            ComputeSecondFibunacciNumber();

            while (LastFoundFibunacciNumberIsNotTooLarge())
            {
                SaveLastComputedFibunacciNumber();
                ComputeNextFibunacciNumber();
            }
        }

        private void ComputeSecondFibunacciNumber()
        {
            _lastFoundFibunacciNumber = SECOND_TO_LOWEST_FIBUNACCI_NUMBER;
        }

        private void ComputeAndSaveFirstFibunacciNumber()
        {
            _lastFoundFibunacciNumber = LOWEST_FIBUNACCI_NUMBER;
            SaveLastComputedFibunacciNumber();
        }

        private void SetDefaultIndex()
        {
            _indexLastFoundFibunacciNumber = INDEX_WITHOUT_FIBUNACCI_NUMBERS_FOUND;
        }

        private bool LastFoundFibunacciNumberIsNotTooLarge()
        {
            return _lastFoundFibunacciNumber <= _upperBound;
        }

        private void SaveLastComputedFibunacciNumber()
        {
            _fibunacciNumbers.Add(_lastFoundFibunacciNumber);
            _indexLastFoundFibunacciNumber++;
        }

        private void ComputeNextFibunacciNumber()
        {
            _lastFoundFibunacciNumber = _fibunacciNumbers[_indexLastFoundFibunacciNumber - 1] +
                                       _fibunacciNumbers[_indexLastFoundFibunacciNumber];
        }
    }
}