using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
