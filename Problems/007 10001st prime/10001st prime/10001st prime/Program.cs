using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://projecteuler.net/problem=7

//10001st prime
//Problem 7

//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

//What is the 10 001st prime number?


namespace _10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfPrime = 10001;

            int prime = PrimeGenerator.GetNthPrime(numberOfPrime);

            Console.WriteLine(prime);
            Console.ReadKey();
        }
    }

    
}
