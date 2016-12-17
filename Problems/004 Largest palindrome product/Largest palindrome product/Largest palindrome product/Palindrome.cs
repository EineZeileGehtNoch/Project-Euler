using System;
using System.Collections.Generic;

namespace Largest_palindrome_product
{
    static class Palindrome
    {
        private static int _number;

        private static List<int> digits;


        public static bool NumberIsPalindrome(int number)
        {
            _number = number;

            ReadDigits();

            return DigitsBelongToPalindrome();
        }

        private static void ReadDigits()
        {
            CreateEmptyDigitList();
            FillDigitList();
        }

        private static bool DigitsBelongToPalindrome()
        {
            for (int index = 0; index < digits.Count; index++)
            {
                if (DigitIsNotSimmetricalInNumber(index))
                {
                    return false;
                }
            }

            return true;
        }

        private static void CreateEmptyDigitList()
        {
            digits = new List<int>();
        }

        private static void FillDigitList()
        {
            while (DigitsLeft())
            {
                SafeAndRemoveLastDigit();
            }
        }

        private static bool DigitsLeft()
        {
            return _number>0;
        }

        private static void SafeAndRemoveLastDigit()
        {
            SafeLastDigit(digits);
            RemoveLastDigitFromNumber();
        }

        private static void RemoveLastDigitFromNumber()
        {
            _number /= 10;
        }

        private static void SafeLastDigit(List<int> digits)
        {
            digits.Add(_number%10);
        }

        private static bool DigitIsNotSimmetricalInNumber(int index)
        {
            return digits[index] != digits[digits.Count - index-1];
        }
    }
}
