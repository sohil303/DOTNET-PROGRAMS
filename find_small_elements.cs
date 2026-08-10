using System;

namespace CalculatorApplication
{
    public class FindSmallElements
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter the size of array: ");
            int size;
            if (!int.TryParse(Console.ReadLine(), out size) || size < 2)
            {
                Console.WriteLine("Invalid size. Array must have at least 2 elements.");
                return;
            }

            int[] arr = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                int val;
                while (!int.TryParse(Console.ReadLine(), out val))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    Console.Write("Element {0}: ", i + 1);
                }
                arr[i] = val;
            }

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in arr)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num;
                }
            }

            if (secondSmallest == int.MaxValue)
            {
                Console.WriteLine("There is no second smallest element.");
            }
            else
            {
                Console.WriteLine("The second smallest element is: " + secondSmallest);
            }
            Console.ReadLine();
        }
    }
}
