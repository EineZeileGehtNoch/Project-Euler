﻿using System;
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
            int numberToFactor = 21;


            int highestPrime = PrimeFactory.GetHighestPrime(numberToFactor);
           
            Console.WriteLine("Highest prime factor of "+ numberToFactor +": " + highestPrime);
            Console.ReadKey();

        }

    }
}
