/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _09.IntDoubleOrString
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, choose a type: ");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1: 
                    {
                        Console.WriteLine("Please, enter an int: ");
                        int intValue = int.Parse(Console.ReadLine());
                        intValue += 1;
                        Console.WriteLine("Result: {0}", intValue);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Please, enter a double: ");
                        double doubleValue = double.Parse(Console.ReadLine());
                        doubleValue += 1.0;
                        Console.WriteLine("Result: {0}", doubleValue);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Please, enter a string: ");
                        string stringValue = Console.ReadLine();
                        stringValue += "*";
                        Console.WriteLine("Result: {0}", stringValue);
                        break;
                    }
            }

        }
    }
}
