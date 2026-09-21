// Q6. Write a C# Sharp program to find the maximum and minimum elements in an array.

using System;

class TUT5_Q6
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter {0} elements:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
                max = arr[i];
            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine("\nMaximum element in the array: " + max);
        Console.WriteLine("Minimum element in the array: " + min);
        Console.ReadLine();
    }
}
