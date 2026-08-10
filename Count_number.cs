//Count Positive, Negative and Zero Numbers using Entered Array

using System;

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
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;

        for (int i = 0; i < size; i++)
        {
            if (arr[i] > 0)
            {
                positiveCount++;
            }
            else if (arr[i] < 0)
            {
                negativeCount++;
            }
            else
            {
                zeroCount++;
            }
        }

        Console.WriteLine("\nPositive numbers: " + positiveCount);
        Console.WriteLine("Negative numbers: " + negativeCount);
        Console.WriteLine("Zero numbers: " + zeroCount);

        Console.ReadLine();
    }
}
