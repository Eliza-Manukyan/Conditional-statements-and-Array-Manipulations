/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulations
{
    internal class _5
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

            // Reverse the array
            ReverseArray(numbers);

            // Display the reversed array
            Console.WriteLine("Reversed array:");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

        static void ReverseArray(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start < end)
            {
                // Swap elements at start and end indices
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;

                // Move indices towards the center
                start++;
                end--;
            }
        }
    }

}*/
