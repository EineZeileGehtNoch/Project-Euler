using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://projecteuler.net/problem=1

//Multiples of 3 and 5
//Problem 1

//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Find the sum of all the multiples of 3 or 5 below 1000.


namespace Multiples_of_3_and_5
{
    class Program
    {

        static void Main(string[] args)
        {
            int maxInteger = 1000;
            List<int> factors = new List<int> {3, 5};

            int sum = Adder.SumOfNumbersDividedByFactors(maxInteger, factors);

            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();

        }
    }
}
