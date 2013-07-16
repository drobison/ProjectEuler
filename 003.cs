using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Largest prime factor
//Problem 3

//The prime factors of 13195 are 5, 7, 13 and 29.

//What is the largest prime factor of the number 600851475143 ?

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            double largestPrime = 0;
            for (double x = 0; x < (double)Math.Sqrt(600851475143); x++)
            {
                if (isPrime(x))
                {
                    if (600851475143 % x == 0)
                        largestPrime = x;
                }

            }
            Console.WriteLine(largestPrime);

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
