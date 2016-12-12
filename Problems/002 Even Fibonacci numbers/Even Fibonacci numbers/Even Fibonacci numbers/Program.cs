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
            int maximumFibunacciNumber = 2;
            List<int> fibunacciNumbers;

            fibunacciNumbers = FibunacciGenerator.GetFibunacciNumbersUpTill(maximumFibunacciNumber);



        }
    }
}
