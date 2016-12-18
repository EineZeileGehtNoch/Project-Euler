using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smallest_multiple
{
    class PrimeFactorGenerator
    {
        private static List<int> _numberOfPrimeFactors;
        private static int _number;

        public static List<int> GetNumberOfPrimeFactors(int number)
        {
            SafeInput(number);
            CreateEmptyPrimeFactors();



            return _numberOfPrimeFactors;
        }

        private static void SafeInput(int number)
        {
            _number = number;
        }

        private static void CreateEmptyPrimeFactors()
        {
            _numberOfPrimeFactors = new List<int>();
        }
    }
}
