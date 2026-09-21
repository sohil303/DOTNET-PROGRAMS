// Q10. Write a C# Sharp program for adding two matrices of the same size.

using System;

class TUT5_Q10
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matA   = new int[rows, cols];
        int[,] matB   = new int[rows, cols];
        int[,] result = new int[rows, cols];

        // Input Matrix A
        Console.WriteLine("\nEnter elements of Matrix A:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                Console.Write("A[{0}][{1}]: ", i, j);
                matA[i, j] = int.Parse(Console.ReadLine());
            }

        // Input Matrix B
        Console.WriteLine("\nEnter elements of Matrix B:");
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                Console.Write("B[{0}][{1}]: ", i, j);
                matB[i, j] = int.Parse(Console.ReadLine());
            }

        // Addition
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = matA[i, j] + matB[i, j];

        // Display
        Console.WriteLine("\nResultant Matrix (A + B):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(result[i, j] + "\t");
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
