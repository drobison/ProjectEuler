using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Summation of primes
//Problem 10

//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

//Find the sum of all the primes below two million.

namespace _010
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            double x = 2;
            while (x < 2000000)
            {
                if (isPrime(x))
                {
                    number += x;
                }

                x++;
            }


            Console.WriteLine(number);

        }

        static bool isPrime(double number)
        {
            if (number % 2 == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                return false;
            }

            double max = (double)Math.Sqrt(number);
            for (int i = 3; i <= max; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
