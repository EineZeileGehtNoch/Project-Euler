namespace Largest_palindrome_product
{
    static class PalindromeFinder
    {
        private static int _digitsPerFactor;
        private static int _palindrome;
        private static int _lowerBoundFactor;
        private static int _upperBoundFactor;

        public static int GetLargestPalindromeWhichIsProdukt(int digitsPerFactor)
        {
            _digitsPerFactor = digitsPerFactor;

            FindLargestPalindrom();

            return _palindrome;
        }

        private static void FindLargestPalindrom()
        {
            SetBoundsForFactors();

            TryAllFactorCombinations();
        }

        private static void TryAllFactorCombinations()
        {
            for (int smallerFactor = _lowerBoundFactor; smallerFactor <= _upperBoundFactor; smallerFactor++)
            {
                TryAllBiggerFactors(smallerFactor);
            }
        }

        private static void TryAllBiggerFactors(int smallerFactor)
        {
            for (int biggerFactor = smallerFactor; biggerFactor <= _upperBoundFactor; biggerFactor++)
            {
                int palindromeCandidate = smallerFactor*biggerFactor;

                if (NumberIsPalindrome(palindromeCandidate))
                {
                    SafeIfBiggerThenLastSaved(palindromeCandidate);
                }
            }
        }

        private static void SafeIfBiggerThenLastSaved(int palindromeCandidate)
        {
            if (IsBiggerThenLastSaved(palindromeCandidate))
            {
                _palindrome = palindromeCandidate;
            }
        }

        private static bool IsBiggerThenLastSaved(int palindromeCandidate)
        {
            return palindromeCandidate > _palindrome;
        }

        private static bool NumberIsPalindrome(int palindromeCandidate)
        {
            return PalindromeChecker.NumberIsPalindrome(palindromeCandidate);
        }

        private static void SetBoundsForFactors()
        {
            _lowerBoundFactor = TenToThePowerOf(_digitsPerFactor-1);
            _upperBoundFactor = TenToThePowerOf(_digitsPerFactor) - 1;
        }

        private static int TenToThePowerOf(int exponent)
        {
            int number = 1;

            for (int i = 0; i < exponent; i++)
            {
                number *= 10;
            }

            return number;
        }
    }
}
