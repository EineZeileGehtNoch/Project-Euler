using System.Linq.Expressions;

namespace Special_Pythagorean_triplet
{
    static class Pythagorean
    {
        private static int _sum;
        private static IntegerTuple _pythagoreanTriplet;

        public const int SMALLEST_INTEGER = 1;

        public static IntegerTuple GetTripletWithSumOf(int sum)
        {
            SaveSum(sum);

            FindPythagoreanTriplet();

            return _pythagoreanTriplet;
        }

        private static void FindPythagoreanTriplet()
        {
            for (int a = SMALLEST_INTEGER; a <= _sum; a++)
            {
                TryAllBsAndCs(a);
            }
        }

        private static void TryAllBsAndCs(int a)
        {
            for (int b = a + 1; b <= _sum; b++)
            {
                TryAllCs(a, b);
            }
        }

        private static void TryAllCs(int a, int b)
        {
            for (int c = SMALLEST_INTEGER; c <= _sum; c++)
            {
                SaveIfTripletFullfillsConditions(a, b, c);
            }
        }

        private static void SaveIfTripletFullfillsConditions(int a, int b, int c)
        {
            if (FullfillsConditions(a, b, c))
            {
                SaveTriplet(a, b, c);
            }
        }

        private static bool FullfillsConditions(int a, int b, int c)
        {
            return IsPythagoreanTriplet(a, b, c)&& HasCorrectSum(a, b, c);
        }

        private static bool HasCorrectSum(int a, int b, int c)
        {
            return a+b+c == _sum;
        }

        private static void SaveTriplet(int a, int b, int c)
        {
            _pythagoreanTriplet = new IntegerTuple(a, b, c);
        }

        private static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return a*a + b*b == c*c;
        }

        private static void SaveSum(int sum)
        {
            _sum = sum;
        }
    }
}
