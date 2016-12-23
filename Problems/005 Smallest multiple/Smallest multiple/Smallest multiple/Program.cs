using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://projecteuler.net/problem=5

//Smallest multiple
//Problem 5

//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


namespace Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int number = 1; number <= 20; number++)
            {
                numbers.Add(number);
            }

            int leastCommonMultiple = LeastCommonMultipleGenerator.GetLcmOf(numbers);


            Console.WriteLine(leastCommonMultiple);
            Console.ReadKey();
        }
    }
}
