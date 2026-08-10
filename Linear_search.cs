//Perform linear search in an array
using System;

namespace LinearSearchNamespace
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to search: ");
            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                if (arr[i] == target)
                {
                    Console.WriteLine("Element found at index: " + i);
                    return;
                }
                if (i == size - 1)
                {
                    Console.WriteLine("Element not found.");
                }
            }
            
        }
    }
}
