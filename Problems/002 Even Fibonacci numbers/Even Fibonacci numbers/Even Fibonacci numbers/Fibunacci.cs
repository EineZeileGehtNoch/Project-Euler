using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class Fibunacci
    {
        public int SumEvenNumbersUpTo(int maximumFibunacciNumber)
        {
            var fibunacciNumbers = GetFibunacciNumbersUpTo(maximumFibunacciNumber);

            return NumberAdder.SumOfEvenNumbers(fibunacciNumbers);
        }

        private List<int> GetFibunacciNumbersUpTo(int maximumFibunacciNumber)
        {
            List<int> fibunacciNumbers;
            fibunacciNumbers = new List<int>();
            int lastFoundFibunacciNumber = 1;
            fibunacciNumbers.Add(lastFoundFibunacciNumber);
            int indexLastFoundFibunacciNumber = 0;
            
            lastFoundFibunacciNumber = 2;

            while (lastFoundFibunacciNumber <= maximumFibunacciNumber)
            {
                fibunacciNumbers.Add(lastFoundFibunacciNumber);
                indexLastFoundFibunacciNumber++;
                lastFoundFibunacciNumber = fibunacciNumbers[indexLastFoundFibunacciNumber - 1] +
                                           fibunacciNumbers[indexLastFoundFibunacciNumber];
           }

            return fibunacciNumbers;
        }
    }
}