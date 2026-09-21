// Q2. Declare single dimensional array, accept 5 integers, sort ascending and display.

using System;

class TUT5_Q2
{
    static void Main()
    {
        int[] arr = new int[5];

        Console.WriteLine("Enter 5 integer values:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Element [{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Bubble Sort - Ascending
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nArray sorted in Ascending Order:");
        foreach (int val in arr)
            Console.Write(val + " ");

        Console.WriteLine();
        Console.ReadLine();
    }
}
