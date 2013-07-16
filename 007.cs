using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10001st prime
//Problem 7

//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

//What is the 10 001st prime number?


namespace _007
{
    class Program
    {
        static List<int> primes = new List<int>();

        static void Main(string[] args)
        {
            int x = 2;
            while(primes.Count != 10001)
            {
                if (isPrime(x))
                    primes.Add(x);
                x++;
            }
            Console.WriteLine(primes[10000]);
            
        }

        static bool isPrime(int number)
        {
            for (int x = 0; x < primes.Count; x++)
            {
                if (number % primes[x] == 0)
                    return false;
            }
            return true;

        }


    }
}
