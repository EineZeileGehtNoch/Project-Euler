using System.Collections.Generic;

namespace Summation_of_primes
{
    static class ListIntExtension
    {
        private static int _product;

        public static int Product(this List<int> factors)
        {
            ComputeProduct(factors);

            return _product;
        }

        private static void ComputeProduct(List<int> factors)
        {
            SetProductToDefault();

            AddFactorsToProduct(factors);
        }

        private static void AddFactorsToProduct(List<int> factors)
        {
            foreach (int factor in factors)
            {
                AddToProduct(factor);
            }
        }

        private static void AddToProduct(int factor)
        {
            _product *= factor;
        }

        private static void SetProductToDefault()
        {
            _product = 1;
        }
    }
}
