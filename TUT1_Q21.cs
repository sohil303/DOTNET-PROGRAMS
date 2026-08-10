using System;

namespace CalculatorApplication
{
    public class TUT1_Q21
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Input the number of terms : ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Console.Write("Input number : ");
            if (!int.TryParse(Console.ReadLine(), out int digit) || digit < 0 || digit > 9)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            long sum = 0;
            long term = 0;

            Console.WriteLine("Expected Output :");
            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + digit;
                sum += term;

                Console.Write(term);
                if (i < n)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("The Sum is : " + sum);
            Console.ReadLine();
        }
    }
}
