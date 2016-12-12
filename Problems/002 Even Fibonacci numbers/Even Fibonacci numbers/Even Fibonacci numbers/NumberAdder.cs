using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class NumberAdder
    {
        public static int sumOfEvenNumbers(List<int> fibunacciNumbers)
        {
            int sumEvenFibunacciNumbers;
            sumEvenFibunacciNumbers = 0;

            foreach (int fibunacciNumber in fibunacciNumbers)
            {
                if (fibunacciNumber%2 == 0)
                {
                    sumEvenFibunacciNumbers += fibunacciNumber;
                }
            }
            return sumEvenFibunacciNumbers;
        }
    }
}