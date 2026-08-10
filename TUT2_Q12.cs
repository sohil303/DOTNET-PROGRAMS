using System;

namespace CalculatorApplication
{
    public class TUT2_Q12
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static int SearchElement(int[] arr, int target)
        {
            foreach (int element in arr)
            {
                if (element == target)
                {
                    return 1;
                }
            }
            return 0;
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
            Console.WriteLine("Enter {0} space-separated elements (or enter them one by one):", n);
            int count = 0;
            while (count < n)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                string[] tokens = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var token in tokens)
                {
                    if (count < n)
                    {
                        int val;
                        if (int.TryParse(token, out val))
                        {
                            arr[count++] = val;
                        }
                        else
                        {
                            Console.WriteLine("Invalid element '{0}' ignored. Please enter valid integers.", token);
                        }
                    }
                }
            }

            Console.Write("Enter the element to search: ");
            int target;
            if (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.WriteLine("Invalid input for target.");
                return;
            }

            int result = SearchElement(arr, target);
            Console.WriteLine("Output: {0}", result);

            Console.ReadLine();
        }
    }
}
