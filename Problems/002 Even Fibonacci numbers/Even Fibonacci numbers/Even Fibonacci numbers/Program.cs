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
            int sumEvenFibunacciNumbers;

            int maximumFibunacciNumber = 4000000;
            List<int> fibunacciNumbers;

            fibunacciNumbers = FibunacciGenerator.GetNumbersUpTill(maximumFibunacciNumber);

            sumEvenFibunacciNumbers = NumberAdder.sumOfEvenNumbers(fibunacciNumbers);

            Console.WriteLine("Sum: " + sumEvenFibunacciNumbers);
            Console.ReadKey();

        }
    }
}
