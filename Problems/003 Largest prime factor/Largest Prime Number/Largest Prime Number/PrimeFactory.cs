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
        private const int FirstPrime = 2;

        public static int GetHighestPrime(int numberToFactor)
        {
            PrimeFactory primeFactory = new PrimeFactory();

            int highestPrime = 1;
            while (numberToFactor > 1)
            {
                int prime = primeFactory.ReturnFirstOrNextPrime();

                while (numberToFactor % prime == 0)
                {
                    highestPrime = prime;
                    numberToFactor /= prime;
                }
            }
            return highestPrime;
        }

        private int ReturnFirstOrNextPrime()
        {
            return FirstTimeUsed() ? GetFirstPrime() : GetNextPrime();
        }

        private bool FirstTimeUsed()
        {
            return _primes.Count==0;
        }

        private int GetFirstPrime()
        {
            _primes.Add(FirstPrime);
            return FirstPrime;
        }

        private int GetNextPrime()
        {
            int firstCandidate = ++_primes[_primes.Count - 1];


            for (int candidate = firstCandidate; candidate < Int32.MaxValue; candidate++)
            {
                if (CandidateIsPrime(candidate))
                {
                    _primes.Add(candidate);
                    Console.WriteLine(" -- " + candidate);
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
                if (CandidateIsDividedByPrime(candidate, prime))
                {
                    candidateIsPrime = false;
                }
            }
            return candidateIsPrime;
        }

        private static bool CandidateIsDividedByPrime(int candidate, int prime)
        {
            return candidate%prime == 0;
        }
    }
}
