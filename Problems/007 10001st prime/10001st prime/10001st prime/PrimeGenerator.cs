using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001st_prime
{
    static class PrimeGenerator
    {
        private static List<int> _primes;
        private static readonly int FIRST_PRIME =2;

        public static int GetNthPrime(int numberOfPrime)
        {
            InitiatePrimeList();

            ComputePrimes(numberOfPrime);

            return GetLastPrime();
        }

        private static void ComputePrimes(int numberOfPrime)
        {
            AddFirstPrime();
            for (int i = 2; i <= numberOfPrime; i++)
            {
                ComputeAndAddNextPrime();
            }
        }

        private static void AddFirstPrime()
        {
            _primes.Add(FIRST_PRIME);
        }

        private static void ComputeAndAddNextPrime()
        {
            for (int primeCandidate = GetLastPrime() + 1;; primeCandidate++)
            {
                if (IsPrime(primeCandidate))
                {
                    AddPrimeToList(primeCandidate);
                    return;
                }
            }
        }

        private static void AddPrimeToList(int primeCandidate)
        {
            _primes.Add(primeCandidate);
        }

        private static bool IsPrime(int primeCandidate)
        {
            foreach (int prime in _primes)
            {
                if (FirstIsDivisibleBySecond(primeCandidate, prime))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool FirstIsDivisibleBySecond(int primeCandidate, int prime)
        {
            return primeCandidate%prime == 0;
        }

        private static void InitiatePrimeList()
        {
            _primes = new List<int>();
        }

        private static int GetLastPrime()
        {
            return _primes.Last();
        }
    }
}
