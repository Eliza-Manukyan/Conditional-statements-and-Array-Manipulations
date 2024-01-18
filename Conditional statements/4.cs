/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulations
{
    internal class _4
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            // Input elements of the array
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Find maximum and minimum
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < size; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Minimum element: {min}");
        }
    }
}*/

