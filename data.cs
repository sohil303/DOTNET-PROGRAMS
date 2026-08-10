// Count Even and Odd Numbers using Entered Array
using System;

namespace DataNamespace
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

        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        Console.WriteLine("\nEven numbers: " + evenCount);
        Console.WriteLine("Odd numbers: " + oddCount);

        Console.ReadLine();
    }
}
}
