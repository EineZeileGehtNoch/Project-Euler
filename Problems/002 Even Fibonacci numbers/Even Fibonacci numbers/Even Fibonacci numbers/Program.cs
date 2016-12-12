using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
