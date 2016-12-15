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

        private List<int> _primes;
        private static readonly int FirstPrime = 2;

        public int ReturnNextPrimeNumber()
        {
            
            if (_primes.Count==0)
            {
                _primes.Add(FirstPrime);
                return FirstPrime;
            }

            int firstCandidate = _primes[_primes.Count - 1] + 1;
            for (int candidate = firstCandidate; ; candidate++)
            {
                foreach (int prime in _primes)
                {
                    if (candidate%prime == 0)
                    {
                        continue;
                    }
                    _primes.Add(candidate);
                    return candidate;
                }
            }
        }
    }
}
