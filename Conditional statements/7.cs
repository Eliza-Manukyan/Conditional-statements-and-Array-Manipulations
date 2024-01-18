using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulations
{
    internal class _7
    {
        static void Main()
        {
            Console.Write("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            int[] array1 = new int[size];
            int[] array2 = new int[size];

            // Input elements of the first array
            Console.WriteLine("Enter elements for the first array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            // Input elements of the second array
            Console.WriteLine("Enter elements for the second array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            // Calculate the sum of corresponding elements
            int[] resultArray = SumArrays(array1, array2);

            // Display the result array
            Console.WriteLine("Result array (sum of corresponding elements):");
            foreach (int sum in resultArray)
            {
                Console.Write($"{sum} ");
            }
        }

        static int[] SumArrays(int[] array1, int[] array2)
        {
            int[] resultArray = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i] + array2[i];
            }

            return resultArray;
        }
    }

}

