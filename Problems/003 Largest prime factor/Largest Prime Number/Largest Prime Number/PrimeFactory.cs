using System.Collections.Generic;

namespace Largest_Prime_Number
{
    class PrimeFactory
    {
        public PrimeFactory()
        {
            _primes = new List<long>();
        }

        private readonly List<long> _primes;
        private const long FirstPrime = 2;

        public static long GetHighestPrime(long numberToFactor)
        {
            PrimeFactory primeFactory = new PrimeFactory();

            long highestPrime = 1;
            while (numberToFactor > 1)
            {
                long prime = primeFactory.ReturnFirstOrNextPrime();

                while (numberToFactor % prime == 0)
                {
                    highestPrime = prime;
                    numberToFactor /= prime;
                }
            }
            return highestPrime;
        }

        private long ReturnFirstOrNextPrime()
        {
            return FirstTimeUsed() ? GetFirstPrime() : GetNextPrime();
        }

        private bool FirstTimeUsed()
        {
            return _primes.Count==0;
        }

        private long GetFirstPrime()
        {
            _primes.Add(FirstPrime);
            return FirstPrime;
        }

        private long GetNextPrime()
        {
            long firstCandidate = _primes[_primes.Count - 1] + 1;


            for (long candidate = firstCandidate;; candidate++)
            {
                if (CandidateIsPrime(candidate))
                {
                    _primes.Add(candidate);
                    return candidate;
                }
            }
            
       }

        private bool CandidateIsPrime(long candidate)
        {
            var candidateIsPrime = true;
            foreach (long prime in _primes)
            {
                if (CandidateIsDividedByPrime(candidate, prime))
                {
                    candidateIsPrime = false;
                }
            }
            return candidateIsPrime;
        }

        private static bool CandidateIsDividedByPrime(long candidate, long prime)
        {
            return candidate%prime == 0;
        }
    }
}
