using System.Linq.Expressions;

namespace Special_Pythagorean_triplet
{
    class Pythagorean
    {
        private static int _sum;

        public const int SMALLEST_INTEGER = 1;

        public static IntegerTuple GetTripletWithSumOf(int sum)
        {
            SaveSum(sum);

            for (int a = SMALLEST_INTEGER; a <= _sum; a++)
            {
                for (int b = a+1; b < _sum; b++)
                {
                    for (int c = SMALLEST_INTEGER; c < _sum; c++)
                    {

                        if (a*a + b*b == c*c)
                        {

                        }
   
                    }

                }
                
            }


            return null;
        }

        private static void SaveSum(int sum)
        {
            _sum = sum;
        }
    }
}
