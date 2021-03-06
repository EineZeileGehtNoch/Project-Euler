﻿using System;

//https://projecteuler.net/problem=9

//Special Pythagorean triplet
//Problem 9

//A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
//a^2 + b^2 = c^2

//For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.


namespace Special_Pythagorean_triplet
{
    class Program
    {
        static void Main()
        {
            int sum = 1000;

            IntegerTuple abc = Pythagorean.GetTripletWithSumOf(sum);
            int product =abc.GetProduct();

            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}
