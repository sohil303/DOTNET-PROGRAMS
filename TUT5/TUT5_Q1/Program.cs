// Q1. Write a C# Sharp program that stores elements in an array and prints them.

using System;

class TUT5_Q1
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Elements in the array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
        }

        Console.ReadLine();
    }
}
