/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _07.Sort3Numbers
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

            if (a > b && a > c)
            {
                Console.Write(a + ", ");
                if (b > c)
                {
                    Console.Write(b + ", " + c);
                }
                else
                {
                    Console.Write(c + ", " + b);
                }
            }
            else if (b > a && b > c)
            {
                Console.Write(b + ", ");
                if (a > c)
                {
                    Console.Write(a + ", " + c);
                }
                else
                {
                    Console.Write(c + ", " + a);
                }
            }
            else if (c > a && c > b)
            {
                Console.Write(c + ", ");
                if (a > b)
                {
                    Console.Write(a + ", " + b);
                }
                else
                {
                    Console.Write(b + ", " + a);
                }
            }

            Console.WriteLine();
        }
    }
}
