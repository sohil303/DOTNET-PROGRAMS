// Q4. Write a C# Sharp program to copy the elements of one array into another array.

using System;

class TUT5_Q4
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] source = new int[n];
        int[] destination = new int[n];

        Console.WriteLine("Enter {0} elements for the source array:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [{0}]: ", i);
            source[i] = int.Parse(Console.ReadLine());
        }

        // Copy elements
        for (int i = 0; i < n; i++)
        {
            destination[i] = source[i];
        }

        Console.WriteLine("\nSource Array:");
        foreach (int val in source)
            Console.Write(val + " ");

        Console.WriteLine("\nDestination Array (Copied):");
        foreach (int val in destination)
            Console.Write(val + " ");

        Console.WriteLine();
        Console.ReadLine();
    }
}
