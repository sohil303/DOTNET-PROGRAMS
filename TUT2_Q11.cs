using System;

namespace CalculatorApplication
{
    public class TUT2_Q11
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter the number of elements (N): ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid value for N. Please enter a positive integer.");
                return;
            }

            int[] arr = new int[n];
            int sum = 0;

            Console.WriteLine("Enter the {0} elements:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                int element;
                while (!int.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("Element {0}: ", i + 1);
                }
                arr[i] = element;
                sum += arr[i];
            }

            Console.WriteLine("The sum of the array elements is: {0}", sum);
            Console.ReadLine();
        }
    }
}
