using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smallest_multiple
{
    class PrimeFactorGenerator
    {
        private static List<int> _primeFactors;

        public static List<int> GetNumberOfPrimeFactors(int number)
        {
            CreateEmptyPrimeFactors();

            return _primeFactors;
        }

        private static void CreateEmptyPrimeFactors()
        {
            _primeFactors = new List<int>();
        }
    }
}
