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

            ComputePrimeFactors();

            return _numberOfPrimeFactors;
        }

        private static void ComputePrimeFactors()
        {
            CreateNewPrimeNumberSource();
            CreateEmptyPrimeFactors();
            CountPrimeFactors();
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
           while (NumberIsDivisibleBy(prime))
           {
               DiviseNumberBy(prime);
               IncreasePrimeFactorCounter();
           }
        }

        private static void IncreasePrimeFactorCounter()
        {
            _numberOfPrimeFactors[_numberOfPrimeFactors.Count - 1]++;
        }

        private static void DiviseNumberBy(int prime)
        {
            _number /= prime;
        }

        private static bool NumberIsDivisibleBy(int prime)
        {
            return _number%prime == 0;
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
