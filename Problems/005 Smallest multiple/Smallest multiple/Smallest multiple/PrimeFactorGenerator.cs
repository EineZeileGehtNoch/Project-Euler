using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smallest_multiple
{
    class PrimeFactorGenerator
    {
        private static List<int> _numberOfPrimeFactors;
        private static int _number;
        private static PrimeGenerator _primeGenerator;

        public static List<int> GetNumberOfPrimeFactors(int number)
        {
            SafeInput(number);
            CreateNewPrimeNumberSource();
            CreateEmptyPrimeFactors();

            CountPrimeFactors();

            return _numberOfPrimeFactors;
        }

        private static void CountPrimeFactors()
        {
            while (PrimeFactorsLeftInNumber())
            {
                int prime = _primeGenerator.GetFirstOrNextPrime();

                CountHowOftenDivisibleBy(prime);
            }
        }

        private static void CountHowOftenDivisibleBy(int prime)
        {
            _numberOfPrimeFactors.Add(0);
            if (_number%prime == 0)
            {
                _number /= prime;
                _numberOfPrimeFactors[_numberOfPrimeFactors.Count - 1]++;
            }
        }

        private static bool PrimeFactorsLeftInNumber()
        {
            return _number>1;
        }

        private static void CreateNewPrimeNumberSource()
        {
            _primeGenerator = new PrimeGenerator();
        }

        private static void SafeInput(int number)
        {
            _number = number;
        }

        private static void CreateEmptyPrimeFactors()
        {
            _numberOfPrimeFactors = new List<int>();
        }
    }


}
