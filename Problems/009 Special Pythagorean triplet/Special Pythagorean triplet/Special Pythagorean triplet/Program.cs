using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static void Main(string[] args)
        {
            int sum = 1000;

            Triplet abc = Pythagorean.GetSmallestTripletWithSumOf(sum);
            int product = abc.A*abc.B*abc.C;

            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}
