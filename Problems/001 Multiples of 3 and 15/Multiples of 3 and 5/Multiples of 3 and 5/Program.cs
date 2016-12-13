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
        private const int MaxInteger = 1000;

        static void Main(string[] args)
        {
            int sum = 0;

            for (int integer = 0; integer < MaxInteger; integer++)
            {
                if(integer%3==0||integer%5==0)
                {
                    sum += integer;
                }
            }

            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();

        }
    }
}
