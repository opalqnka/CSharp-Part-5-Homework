/*Problem 10.* Beer Time

A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 
Note: You may need to learn how to parse dates and times.
*/

using System;
using System.Threading;
using System.Globalization;


namespace _10.BeerTime
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter the time in the format [hh:mm TT]:");
            string time = Console.ReadLine();

            //define the beer-time window
            DateTime start = DateTime.Parse("1:00 PM");
            DateTime finish = DateTime.Parse("3:00 AM");

            //use try-catch statement https://msdn.microsoft.com/en-us/library/0yd65esw.aspx
            try
            {
                DateTime beerTime = DateTime.Parse(time);

                if (beerTime >= start || beerTime < finish)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }

            catch
            {
                Console.WriteLine("invalid time");
            }
            
        }
    }
}
