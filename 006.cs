using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sum square difference
//Problem 6

//The sum of the squares of the first ten natural numbers is,
//12 + 22 + ... + 102 = 385

//The square of the sum of the first ten natural numbers is,
//(1 + 2 + ... + 10)2 = 552 = 3025

//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.


namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(squareOfSum(100) - sumOfSquares(100));
        }

        static int squareOfSum(int count)
        {
            int sum = 0;
            for (int x = 1; x <= count; x++)
            {
                sum += x;
            }
            return sum * sum;
        }

        static int sumOfSquares(int count)
        {
            int sum = 0;
            for (int x = 1; x <= count; x++)
            {
                sum += (x * x);
            }
            return sum;
        }
    }
}
