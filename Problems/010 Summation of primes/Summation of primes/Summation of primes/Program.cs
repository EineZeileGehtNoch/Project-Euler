using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//https://projecteuler.net/problem=10

//Summation of primes
//Problem 10

//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

//Find the sum of all the primes below two million.


namespace Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBound = 2000000;

            List<int> primes = Prime.GetPrimesBelow(upperBound);
            BigInteger sum = primes.Sum();

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
