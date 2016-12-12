using System.Collections.Generic;

namespace Even_Fibonacci_numbers
{
    class NumberAdder
    {
        public static int SumOfEvenNumbers(List<int> numbers)
        {
            var sumEvenNumbers = 0;

            foreach (int number in numbers)
            {
                if (IsEven(number))
                {
                    sumEvenNumbers += number;
                }
            }

            return sumEvenNumbers;
        }

        private static bool IsEven(int fibunacciNumber)
        {
            return fibunacciNumber%2 == 0;
        }
    }
}