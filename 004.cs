using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Largest palindrome product
//Problem 4

//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

//Find the largest palindrome made from the product of two 3-digit numbers.


namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findLargePal());
        }

        static double findLargePal()
       {
           double large = 0;
            for (double x = 999; x > 1; x--)
            {
                for (double y = 999; y > 1; y--)
                {
                    double z = x * y;
                    if (isPal(z))
                    {
                        if (z > large)
                            large = z;
                    }
                }
            }
            return large;
        }

        static bool isPal(double z)
        {
            int length = z.ToString().Length;
            for (int x = 0; x <= (length / 2); x++)
            {
                if (getDigit(z, x) != getDigit(z, (length - x - 1)))
                    return false;
            }
            
            return true;
        }

        static double getDigit(double value ,int position)
        {
            string number = value.ToString();
            return number[position] - 48;
        }
    }
}
