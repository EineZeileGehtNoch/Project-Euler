using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smallest_multiple
{
    class PrimeFactorGenerator
    {
        private static List<int> _primeFactors;
        private static int _number;

        public static List<int> GetNumberOfPrimeFactors(int number)
        {
            SafeInput(number);
            CreateEmptyPrimeFactors();



            return _primeFactors;
        }

        private static void SafeInput(int number)
        {
            _number = number;
        }

        private static void CreateEmptyPrimeFactors()
        {
            _primeFactors = new List<int>();
        }
    }
}
