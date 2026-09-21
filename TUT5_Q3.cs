// Q3. Write a C# Sharp program to read n values in an array and display them in reverse order.

using System;

class TUT5_Q3
{
    static void Main()
    {
        Console.Write("Enter the number of elements (n): ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter {0} values:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nArray in Reverse Order:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
