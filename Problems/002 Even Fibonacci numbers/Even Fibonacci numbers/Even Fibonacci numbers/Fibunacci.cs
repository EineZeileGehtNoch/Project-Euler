using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class Fibunacci
    {
        readonly List<int> _fibunacciNumbers = new List<int>();
        private int _maximumFibunacciNumber;

        public List<int> GetFibunacciNumbersUpTo(int maximumFibunacciNumber)
        {
            _maximumFibunacciNumber = maximumFibunacciNumber;

            if (UpperBoundNotTooLow())
            {
                ComputeFibunacciNumbers();
            }

            return _fibunacciNumbers;
        }

        private static readonly int LOWEST_FIBUNACCI_NUMBER=1;

        private void ComputeFibunacciNumbers()
        {
            int lastFoundFibunacciNumber = 1;
            _fibunacciNumbers.Add(lastFoundFibunacciNumber);

            lastFoundFibunacciNumber = 2;

            int indexLastFoundFibunacciNumber = 0;
            while (lastFoundFibunacciNumber <= _maximumFibunacciNumber)
            {
                _fibunacciNumbers.Add(lastFoundFibunacciNumber);
                indexLastFoundFibunacciNumber++;
                lastFoundFibunacciNumber = _fibunacciNumbers[indexLastFoundFibunacciNumber - 1] +
                                           _fibunacciNumbers[indexLastFoundFibunacciNumber];
            }
        }

        private bool UpperBoundNotTooLow()
        {
            return _maximumFibunacciNumber>=LOWEST_FIBUNACCI_NUMBER;
        }
    }
}