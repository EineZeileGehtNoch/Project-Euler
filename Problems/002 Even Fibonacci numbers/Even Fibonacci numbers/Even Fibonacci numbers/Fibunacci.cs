using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class Fibunacci
    {
        List<int> fibunacciNumbers = new List<int>();

        public List<int> GetFibunacciNumbersUpTo(int maximumFibunacciNumber)
        {
            if (UpperBoundTooLow(maximumFibunacciNumber))
            {
                return fibunacciNumbers;
            }

            ComputeFibunacciNumbers(maximumFibunacciNumber);

            return fibunacciNumbers;
        }

        private void ComputeFibunacciNumbers(int maximumFibunacciNumber)
        {
            int lastFoundFibunacciNumber = 1;
            fibunacciNumbers.Add(lastFoundFibunacciNumber);

            lastFoundFibunacciNumber = 2;

            int indexLastFoundFibunacciNumber = 0;
            while (lastFoundFibunacciNumber <= maximumFibunacciNumber)
            {
                fibunacciNumbers.Add(lastFoundFibunacciNumber);
                indexLastFoundFibunacciNumber++;
                lastFoundFibunacciNumber = fibunacciNumbers[indexLastFoundFibunacciNumber - 1] +
                                           fibunacciNumbers[indexLastFoundFibunacciNumber];
            }
        }

        private static bool UpperBoundTooLow(int maximumFibunacciNumber)
        {
            return maximumFibunacciNumber<1;
        }
    }
}