/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements
{
    internal class _3
    {
        static void Main()
        {
            Console.WriteLine("Choose conversion direction");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter temperature in Fahrenheit: ");
                    double fahrenheit = double.Parse(Console.ReadLine());
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"Temperature in Celsius: {celsius:F2} °C");
                    break;

                case 2:
                    Console.Write("Enter temperature in Celsius: ");
                    double celsiusInput = double.Parse(Console.ReadLine());
                    double fahrenheitOutput = (celsiusInput * 9 / 5) + 32;
                    Console.WriteLine($"Temperature in Fahrenheit: {fahrenheitOutput:F2} °F");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                    break;
            }
        }
    }

}*/

