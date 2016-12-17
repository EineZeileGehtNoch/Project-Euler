using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class Fibunacci
    {
        List<int> _fibunacciNumbers;
        private int _upperBound;
        private int _lastFoundFibunacciNumber;

        private static readonly int LOWEST_FIBUNACCI_NUMBER = 1;
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
                FillList();
            }
        }

        private bool UpperBoundNotTooLow()
        {
            return _upperBound >= LOWEST_FIBUNACCI_NUMBER;
        }

        private void FillList()
        {
            ComputeAndSaveFirstFibunacciNumber();
            ComputeAndSaveOtherFibunacciNumbers();
        }

        private void ComputeAndSaveOtherFibunacciNumbers()
        {
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

        private bool LastFoundFibunacciNumberIsNotTooLarge()
        {
            return _lastFoundFibunacciNumber <= _upperBound;
        }

        private void SaveLastComputedFibunacciNumber()
        {
            _fibunacciNumbers.Add(_lastFoundFibunacciNumber);
        }

        private void ComputeNextFibunacciNumber()
        {
            int lastIndex = _fibunacciNumbers.Count;

            _lastFoundFibunacciNumber = _fibunacciNumbers[lastIndex - 2] +
                                        _fibunacciNumbers[lastIndex - 1];
        }
    }
}