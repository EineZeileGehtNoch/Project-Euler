//https://projecteuler.net/problem=4

//Largest palindrome product
//Problem 4

//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

//Find the largest palindrome made from the product of two 3-digit numbers.


using System;

namespace Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDigits = 3;

            int palindrome = PalindromeFinder.GetLargestPalindromeWhichIsProdukt(numberOfDigits);


            Console.WriteLine("Largest 3-digit Palindrome: " + palindrome);
            Console.ReadKey();
        }
    }
}
