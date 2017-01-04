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


        public static List<int> GetFirstNPrimes(int number)
        {
            CreatePrimesList(number);

            return _primes;
        }

        private static void CreatePrimesList(int number)
        {
            CreateEmptyPrimeList();

            FindPrimes(number);
        }

        private static void FindPrimes(int number)
        {
            while (MorePrimesNeeded(number))
            {
                FindNextPrime();
            }
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

        private static bool MorePrimesNeeded(int number)
        {
            return _primes.Count<number;
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
