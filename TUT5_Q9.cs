// Q9. Write a C# Sharp program to delete an element at the desired position from an array.

using System;

class TUT5_Q9
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

        Console.Write("\nEnter the position to delete (1 to {0}): ", n);
        int pos = int.Parse(Console.ReadLine());

        if (pos < 1 || pos > n)
        {
            Console.WriteLine("Invalid position!");
        }
        else
        {
            // Shift elements left from the deletion position
            for (int i = pos - 1; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            n--; // Reduce effective array size

            Console.WriteLine("\nArray after deletion:");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
