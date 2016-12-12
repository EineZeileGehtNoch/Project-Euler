using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class FibunacciGenerator
    {
        public static List<int> GetFibunacciNumbersUpTill(int maximumFibunacciNumber)
        {
            List<int> fibunacciNumbers;
            fibunacciNumbers = new List<int>();
            int lastFoundFibunacciNumber = 1;
            fibunacciNumbers.Add(lastFoundFibunacciNumber);
            lastFoundFibunacciNumber = 2;
            fibunacciNumbers.Add(2);
            int indexLastFoundFibunacciNumber = 1;

            while (lastFoundFibunacciNumber <= maximumFibunacciNumber)
            {
                lastFoundFibunacciNumber = fibunacciNumbers[indexLastFoundFibunacciNumber - 1] +
                                           fibunacciNumbers[indexLastFoundFibunacciNumber];
                indexLastFoundFibunacciNumber++;
            }

            return fibunacciNumbers;
        }
    }
}