using System.Collections.Generic;

namespace Multiples_of_3_and_5
{
    class Adder
    {
        public static int SumOfNumbersDividedByFactors(int maxInteger, List<int> factors)
        {
            int sum = 0;

            for (int integer = 1; integer < maxInteger; integer++)
            {
                bool isDividedByFactors = IsDividedByFactors(factors, integer);
                if (isDividedByFactors)
                {
                    sum += integer;
                }
            }
            return  sum;
        }

        private static bool IsDividedByFactors(List<int> factors, int integer)
        {
            return integer%factors[0] == 0 || integer%factors[1] == 0;
        }
    }
}