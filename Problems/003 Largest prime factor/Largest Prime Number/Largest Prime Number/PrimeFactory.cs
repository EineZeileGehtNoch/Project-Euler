using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Prime_Number
{
    class PrimeFactory
    {
        public PrimeFactory()
        {
            _primes = new List<int>();
        }

        private readonly List<int> _primes;
        private static readonly int FirstPrime = 2;

        public int ReturnFirstOrNextPrime()
        {
            return FirstTimeUsed() ? GetFirstPrime() : GetNextPrime();
        }

        private bool FirstTimeUsed()
        {
            return _primes.Count==0;
        }

        private int GetFirstPrime()
        {
            int nextPrime;
            _primes.Add(FirstPrime);
            return FirstPrime;
        }

        private int GetNextPrime()
        {
            int nextPrime;
            int firstCandidate = ++_primes[_primes.Count - 1];


            for (int candidate = firstCandidate; candidate < Int32.MaxValue; candidate++)
            {
                if (CandidateIsPrime(candidate))
                {
                    _primes.Add(candidate);
                    return candidate;
                }
                candidate++;
            }
            throw new Exception("There was no next prime Number before going over Int32.MaxValue:" + Int32.MaxValue);
        }

        private bool CandidateIsPrime(int candidate)
        {
            var candidateIsPrime = true;
            foreach (int prime in _primes)
            {
                if (candidate%prime != 0)
                {
                    candidateIsPrime = false;
                }
            }
            return candidateIsPrime;
        }
    }
}
