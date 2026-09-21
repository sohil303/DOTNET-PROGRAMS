// Q7. Write a program in C# Sharp to separate odd and even integers into separate arrays.

using System;

class TUT5_Q7
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter {0} integer values:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element [{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int[] odd  = new int[n];
        int[] even = new int[n];
        int oddCount = 0, evenCount = 0;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 == 0)
                even[evenCount++] = arr[i];
            else
                odd[oddCount++] = arr[i];
        }

        Console.Write("\nEven elements: ");
        for (int i = 0; i < evenCount; i++)
            Console.Write(even[i] + " ");

        Console.Write("\nOdd elements:  ");
        for (int i = 0; i < oddCount; i++)
            Console.Write(odd[i] + " ");

        Console.WriteLine();
        Console.ReadLine();
    }
}
