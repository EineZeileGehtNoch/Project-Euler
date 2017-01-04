using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summation_of_primes
{
    static class Prime
    {
        private static List<int> _primes;
        private static readonly int FIRST_PRIME=2;


        public static List<int> GetPrimesBelow(int upperBound)
        {
            CreatePrimesList(upperBound);

            return _primes;
        }

        private static void CreatePrimesList(int upperBound)
        {
            CreateEmptyPrimeList();

            FindPrimes(upperBound);
        }

        private static void FindPrimes(int upperBound)
        {
            while (LastFoundPrimeSmallEnough(upperBound))
            {
                FindNextPrime();
            }

            RemoveLastFoundPrime();
        }

        private static void RemoveLastFoundPrime()
        {
            _primes.Remove(_primes.Last());
        }

        private static void FindNextPrime()
        {
            for (int candidate = FIRST_PRIME;; candidate++)
            {
                if (IsPrime(candidate))
                {
                    _primes.Add(candidate);
                    break;
                }
            }
        }

        private static void CreateEmptyPrimeList()
        {
            _primes = new List<int>();
        }

        private static bool LastFoundPrimeSmallEnough(int upperBound)
        {
            return _primes.Count==0||_primes.Last()<upperBound;
        }

        private static bool IsPrime(int candidate)
        {
            foreach (int prime in _primes)
            {
                if (FirstIsDivisibleBySecond(candidate, prime))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool FirstIsDivisibleBySecond(int candidate, int prime)
        {
            return candidate%prime==0;
        }
    }
}
