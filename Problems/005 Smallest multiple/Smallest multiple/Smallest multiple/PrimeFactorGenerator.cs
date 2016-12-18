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
        private static PrimeGenerator _primeGenerator;

        public static List<int> GetNumberOfPrimeFactors(int number)
        {
            SafeInput(number);
            CreateNewPrimeNumberSource();
            CreateEmptyPrimeFactors();


            return _numberOfPrimeFactors;
        }

        private static void CreateNewPrimeNumberSource()
        {
            _primeGenerator = new PrimeGenerator();
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
