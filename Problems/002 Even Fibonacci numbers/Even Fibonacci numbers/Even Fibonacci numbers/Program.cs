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


namespace Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximumFibunacciNumber = 4000000;
            Fibunacci fibunacci = new Fibunacci();


            var sumEvenFibunacciNumbers = fibunacci.SumEvenNumbersUpTo(maximumFibunacciNumber);
            Console.WriteLine("Sum: " + sumEvenFibunacciNumbers);
            Console.ReadKey();

        }
    }
}
