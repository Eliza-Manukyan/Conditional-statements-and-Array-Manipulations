/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements
{
    internal class _6
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            if (size < 2)
            {
                Console.WriteLine("The array should have at least two elements to find the second largest element.");
                return;
            }

            int[] numbers = new int[size];

            // Input elements of the array
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Find the second largest element
            int secondLargest = FindSecondLargest(numbers);

            Console.WriteLine($"Second largest element: {secondLargest}");
        }

        static int FindSecondLargest(int[] array)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in array)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num < largest)
                {
                    secondLargest = num;
                }
            }

            return secondLargest;
        }
    }

}*/

