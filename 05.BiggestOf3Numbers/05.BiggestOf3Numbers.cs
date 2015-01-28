/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _05.BiggestOf3Numbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter the three numbers: ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            //Solution using the Math.Max method (remove the comments below)
            //Console.WriteLine(Math.Max(Math.Max(a, b), c));

            //Solution using if-statements
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (a > b && a < c)
            {
                Console.WriteLine(c);
            }
            else if (a < b && b > c)
            {
                Console.WriteLine(b);
            }
            else if (a < b && b < c)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("The three numbers are equal.");
            }           

        }
    }
}
