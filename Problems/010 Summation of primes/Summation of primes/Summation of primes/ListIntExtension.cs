using System.Collections.Generic;
using System.Numerics;

namespace Summation_of_primes
{
    static class ListIntExtension
    {
        private static BigInteger _sum;

        public static BigInteger Sum(this List<int> summands)
        {
            ComputeSum(summands);

            return _sum;
        }

        private static void ComputeSum(List<int> summands)
        {
            SetSumToDefault();

            AddFactorsToSum(summands);
        }

        private static void AddFactorsToSum(List<int> summands)
        {
            foreach (int summand in summands)
            {
                AddToSum(summand);
            }
        }

        private static void AddToSum(int summand)
        {
            _sum += summand;
        }

        private static void SetSumToDefault()
        {
            _sum = 0;
        }
    }
}
