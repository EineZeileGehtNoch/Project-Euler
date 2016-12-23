using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Smallest_multiple
{
    class LeastCommonMultipleGenerator
    {
        private static List<int> _numbers;
        private static List<List<int>> _numberOfPrimesFactorsOfNumbers;
        private static List<int> _smallesMultiplNumberOfPrimeFactors;
        private static PrimeGenerator _primeGenerator;
        private static int _smallestMultiple;

        public static int GetLcmOf(List<int> numbers)
        {
            SaveNumbers(numbers);

            CalculateEverything();

            return _smallestMultiple;
        }

        private static void CalculateEverything()
        {
            CalculatePrimeFactorsOfNumbers();

            CalculatePrimeFactorsOfLeastCommonMultiple();

            CalculateLcmOutOfPrimeFactors();
        }

        private static void CalculateLcmOutOfPrimeFactors()
        {
            InitializeLcm();
            AddAllFactorsToLcm();
        }

        private static void AddAllFactorsToLcm()
        {
            GeneratePrimeFactorGenerator();
            foreach (int potencyOfPrimeFactor in _smallesMultiplNumberOfPrimeFactors)
            {
                AddFactorToLcmAsOftenAsNeeded(potencyOfPrimeFactor);
            }
        }

        private static void AddFactorToLcmAsOftenAsNeeded(int potencyOfPrimeFactor)
        {
            int prime = _primeGenerator.GetFirstOrNextPrime();
            for (int i = 0; i < potencyOfPrimeFactor; i++)
            {
                _smallestMultiple *= prime;
            }
        }

        private static void InitializeLcm()
        {
            _smallestMultiple = 1;
        }

        private static void GeneratePrimeFactorGenerator()
        {
            _primeGenerator = new PrimeGenerator();
        }

        private static void CalculatePrimeFactorsOfLeastCommonMultiple()
        {
            _smallesMultiplNumberOfPrimeFactors = new List<int>();

            foreach (var numberOfPrimesFactorsOfNumber in _numberOfPrimesFactorsOfNumbers)
            {
                while (PrimeFactorsNeedToBeAdded(numberOfPrimesFactorsOfNumber))
                {
                    AddPrimeFactor();
                }
            }

            foreach (List<int> primesFactorsOfNumber in _numberOfPrimesFactorsOfNumbers)
            {
                for (int primeIndex = 0; primeIndex < primesFactorsOfNumber.Count; primeIndex++)
                {
                    if (_smallesMultiplNumberOfPrimeFactors[primeIndex] < primesFactorsOfNumber[primeIndex])
                    {
                        _smallesMultiplNumberOfPrimeFactors[primeIndex] = primesFactorsOfNumber[primeIndex];
                    }
                }
            }
        }

        private static void CalculatePrimeFactorsOfNumbers()
        {
            _numberOfPrimesFactorsOfNumbers = new List<List<int>>();
            foreach (int number in _numbers)
            {
                List<int> numberOfPrimeFactors = PrimeFactorGenerator.GetNumberOfPrimeFactors(number);
                _numberOfPrimesFactorsOfNumbers.Add(numberOfPrimeFactors);
            }
        }

        private static void AddPrimeFactor()
        {
            _smallesMultiplNumberOfPrimeFactors.Add(0);
        }

        private static bool PrimeFactorsNeedToBeAdded(List<int> numberOfPrimesFactorsOfNumber)
        {
            return _smallesMultiplNumberOfPrimeFactors.Count < numberOfPrimesFactorsOfNumber.Count;
        }

        private static void SaveNumbers(List<int> numbers)
        {
            _numbers = numbers;
        }
    }
}
