﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://projecteuler.net/problem=6

//Sum square difference
//Problem 6

//The sum of the squares of the first ten natural numbers is,
//1^2 + 2^2 + ... + 10^2 = 385

//The square of the sum of the first ten natural numbers is,
//(1 + 2 + ... + 10)^2 = 552 = 3025

//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.


namespace Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBound = 100;

            var difference = SumAndSquare.DifferenceBetweenDifferentOrder(upperBound);

            Console.WriteLine(difference);
            Console.ReadKey();
        }
    }
}
