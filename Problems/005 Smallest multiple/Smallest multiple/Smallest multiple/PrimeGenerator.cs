using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smallest_multiple
{
    class PrimeGenerator
    {
        public PrimeGenerator()
        {
            _primes= new List<int>();
        }

        private readonly List<int> _primes;
        private static readonly int SMALLEST_PRIME = 2;

        public int GetFirstOrNextPrime()
        {
            FindNextPrime();
            return GetLatestPrime();
        }

        private int GetLatestPrime()
        {
            return _primes.Last();
        }

        private void FindNextPrime()
        {
            if (FirstTimeUsed())
            {
                ComputeFirstPrime();
            }
            else
            {
                ComputeNextPrime();                
            }
        }

        private void ComputeNextPrime()
        {
            for (int primeCandidate = GetLatestPrime() + 1; primeCandidate < Int32.MaxValue; primeCandidate++)
            {
                if (IsPrime(primeCandidate))
                {
                    _primes.Add(primeCandidate);
                    break;
                }
            }
        }

        private bool IsPrime(int primeCandidate)
        {
            foreach (var prime in _primes)
            {
                if (IsDivisibleBy(primeCandidate, prime))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsDivisibleBy(int primeCandidate, int prime)
        {
            return primeCandidate%prime==0;
        }

        private void ComputeFirstPrime()
        {
            _primes.Add(SMALLEST_PRIME);
        }

        private bool FirstTimeUsed()
        {
            return _primes.Count==0;
        }
    }
}
