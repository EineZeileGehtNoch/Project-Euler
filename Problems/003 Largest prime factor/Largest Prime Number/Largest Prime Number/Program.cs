using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://projecteuler.net/problem=3

//Largest prime factor
//Problem 3

//The prime factors of 13195 are 5, 7, 13 and 29.

//What is the largest prime factor of the number 600851475143 ?

namespace Largest_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToFactor = 2;
            int highestPrime;
            

            var HighestPrime = GetHighestPrime(numberToFactor);
            highestPrime = HighestPrime;

            Console.WriteLine("Highest prime factor: " + highestPrime);
            Console.ReadKey();

        }

        private static int GetHighestPrime(int numberToFactor)
        {
            PrimeFactory primeFactory = new PrimeFactory();

            int HighestPrime = 1;
            while (numberToFactor > 1)
            {
                int prime = primeFactory.ReturnNextPrimeNumber();

                while (numberToFactor%prime == 0)
                {
                    HighestPrime = prime;
                    numberToFactor /= prime;
                }
            }
            return HighestPrime;
        }
    }
}
