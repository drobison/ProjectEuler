using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Smallest multiple
//Problem 5

//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            bool found = false;

            while (!found)
            {
                x += 20;
                for (int y = 19; y > 1; y--)
                {
                    if (!divisibleBy(x, y))
                        break;
                    if (y == 2)
                        found = true;
                }
            }

            Console.WriteLine(x);
            
        }

        static bool divisibleBy(int number, int divisor)
        {
            if (number % divisor == 0)
                return true;
            else
                return false;
        }

    }
}
