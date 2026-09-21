// Q5. Write a C# Sharp program to count duplicate elements in an array.

using System;

class TUT5_Q5
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

        int duplicateCount = 0;

        Console.WriteLine("\nDuplicate elements found:");
        for (int i = 0; i < n - 1; i++)
        {
            bool printed = false;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j] && !printed)
                {
                    Console.WriteLine(arr[i]);
                    duplicateCount++;
                    printed = true;
                }
            }
        }

        Console.WriteLine("\nTotal duplicate elements: " + duplicateCount);
        Console.ReadLine();
    }
}
