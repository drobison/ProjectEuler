using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Special Pythagorean triplet
//Problem 9

//A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
//a2 + b2 = c2

//For example, 32 + 42 = 9 + 16 = 25 = 52.

//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.


namespace _009
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 1000; x++)
            {
                for (int y = 0; y < 1000; y++)
                {
                    for (int z = 0; z < 1000; z++)
                    {
                        if ( (x*x)+y*y==z*z  && (x + y + z) == 1000 && x< y && y<z)
                            Console.WriteLine("found: " + x + " " + y + " " + z);
                    }
                }
            }
        }
    }
}
