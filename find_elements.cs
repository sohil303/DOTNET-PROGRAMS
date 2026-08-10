// Find the Second Largest Element in an Array

using System;

namespace FindElementsNamespace
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

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest && arr[i] != largest)
                {
                    secondLargest = arr[i];
                }
            }

            Console.WriteLine("Second largest number is: " + secondLargest);

            Console.ReadLine();
        }
    }
}
