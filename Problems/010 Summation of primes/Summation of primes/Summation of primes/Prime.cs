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
            CreatePrimeList(upperBound);


            return _primes;
        }

        private static void CreatePrimeList(int upperBound)
        {
            CreateEmptyPrimeList();


            FindPrimesBelow(upperBound);
        }

        private static void FindPrimesBelow(int upperBound)
        {
            for (int candidate = FIRST_PRIME; candidate < upperBound; candidate++)
            {
                if (IsPrime(candidate))
                {
                    _primes.Add(candidate);
                }
            }
        }


        private static void CreateEmptyPrimeList()
        {
            _primes = new List<int>();
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
