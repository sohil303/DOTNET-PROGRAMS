using System;

namespace CalculatorApplication
{
    public class TUT2_Q9
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter N: ");
            string nStr = Console.ReadLine();
            int n;
            while (!int.TryParse(nStr, out n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for N.");
                Console.Write("Enter N: ");
                nStr = Console.ReadLine();
            }

            int size = 2 * n + 2;
            int[] arr = new int[size];

            Console.WriteLine("Enter {0} space-separated elements (or enter them one by one):", size);
            int count = 0;
            while (count < size)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                string[] tokens = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var token in tokens)
                {
                    if (count < size)
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

            // Find the two distinct numbers using XOR
            int xorSum = 0;
            foreach (int num in arr)
            {
                xorSum ^= num;
            }

            // Find rightmost set bit
            int rightmostSetBit = xorSum & -xorSum;

            int num1 = 0;
            int num2 = 0;

            foreach (int num in arr)
            {
                if ((num & rightmostSetBit) != 0)
                {
                    num1 ^= num;
                }
                else
                {
                    num2 ^= num;
                }
            }

            // Print them in ascending order
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine("The two distinct numbers are:");
            Console.WriteLine("{0} {1}", num1, num2);

            Console.ReadLine();
        }
    }
}
