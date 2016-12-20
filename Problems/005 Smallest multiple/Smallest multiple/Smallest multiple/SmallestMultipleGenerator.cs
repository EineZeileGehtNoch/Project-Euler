using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smallest_multiple
{
    class SmallestMultipleGenerator
    {
        private static List<int> _numbers;
        private static List<List<int>> _numberOfPrimesFactorsOfNumbers;
        private static List<int> _smallesMultiplNumberOfPrimeFactors;

        public static int GetSmallestMultipleOf(List<int> numbers)
        {
            SaveNumbers(numbers);

            _numberOfPrimesFactorsOfNumbers = new List<List<int>>();
            foreach (int number in numbers)
            {
                List<int> numberOfPrimeFactors = PrimeFactorGenerator.GetNumberOfPrimeFactors(number);
                _numberOfPrimesFactorsOfNumbers.Add(numberOfPrimeFactors);
            }

            _smallesMultiplNumberOfPrimeFactors = new List<int>();

            foreach (var numberOfPrimesFactorsOfNumber in _numberOfPrimesFactorsOfNumbers)
            {
                while (PrimeFactorsNeedToBeAdded(numberOfPrimesFactorsOfNumber))
                {
                AddPrimeFactor();
                }
                foreach (List<int> primesFactorsOfNumber in _numberOfPrimesFactorsOfNumbers)
                {
                    for (int primeIndex = 0; primeIndex < primesFactorsOfNumber.Count; primeIndex++)
                    {
                        if (_smallesMultiplNumberOfPrimeFactors[primeIndex]<primesFactorsOfNumber[primeIndex])
                        {
                            _smallesMultiplNumberOfPrimeFactors[primeIndex] = primesFactorsOfNumber[primeIndex];
                        }
                    }
                }
            }

            return 1;
        }

        private static void AddPrimeFactor()
        {
            _smallesMultiplNumberOfPrimeFactors.Add(0);
        }

        private static bool PrimeFactorsNeedToBeAdded(List<int> numberOfPrimesFactorsOfNumber)
        {
            return numberOfPrimesFactorsOfNumber.Count>_smallesMultiplNumberOfPrimeFactors.Count;
        }

        private static void SaveNumbers(List<int> numbers)
        {
            _numbers = numbers;
        }
    }
}
