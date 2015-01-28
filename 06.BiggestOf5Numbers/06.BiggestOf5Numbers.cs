/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
 */
using System;
using System.Threading;
using System.Globalization;

namespace _06.BiggestOf5Numbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter the five numbers: ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());


            //Solution using Math.Max method
            //double max = Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));
            //Console.WriteLine(max);

            //Solution using if-statements
            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine(b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine(c);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine(d);
            }
            else if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine(e);
            }
            else
            {
                Console.WriteLine("The five numbers are equal.");
            }
        }
    }
}
