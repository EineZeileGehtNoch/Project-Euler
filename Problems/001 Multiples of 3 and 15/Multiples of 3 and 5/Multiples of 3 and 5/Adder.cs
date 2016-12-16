using System.Collections.Generic;

namespace Multiples_of_3_and_5
{
    class Adder
    {
        public static int SumOfNumbersBelowDivisibleByAnyFactor(int maxInteger, List<int> factors)
        {
            int sum = 0;

            for (int integer = 1; integer < maxInteger; integer++)
            {
                bool isDividedByFactors = IsDivisibleByAnyFactor(factors, integer);
                if (isDividedByFactors)
                {
                    sum += integer;
                }
            }
            return  sum;
        }

        private static bool IsDivisibleByAnyFactor(List<int> factors, int integer)
        {
            foreach (int factor in factors)
            {
                if (IntegerIsDivisibleByFactor(integer, factor))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IntegerIsDivisibleByFactor(int integer, int factor)
        {
            return integer%factor==0;
        }
    }
}