using System.Collections.Generic;

namespace Multiples_of_3_and_5
{
    class Adder
    {
        public static int SumOfNumbersDividedByFactors(int maxInteger, List<int> factors)
        {
            int sum;
            int dummySum = 0;

            for (int integer = 0; integer < maxInteger; integer++)
            {
                bool isDividedByFactors = integer%factors[0] == 0 || integer%factors[1] == 0;
                if (isDividedByFactors)
                {
                    dummySum += integer;
                }
            }
            sum = dummySum;
            return sum;
        }
    }
}