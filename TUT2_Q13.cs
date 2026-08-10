using System;
using System.Collections.Generic;

namespace CalculatorApplication
{
    public class TUT2_Q13
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter the amount: ");
            int amount;
            if (!int.TryParse(Console.ReadLine(), out amount) || amount < 0)
            {
                Console.WriteLine("Invalid amount. Please enter a non-negative integer.");
                return;
            }

            int temp = amount;
            int[] denominations = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            Dictionary<int, int> noteCounts = new Dictionary<int, int>();

            foreach (int note in denominations)
            {
                noteCounts[note] = temp / note;
                temp %= note;
            }

            Console.WriteLine("Output:");
            Console.WriteLine("Notes of Rs.2000 = {0} Notes of Rs.500 = {1} Notes of Rs.200 = {2}", noteCounts[2000], noteCounts[500], noteCounts[200]);
            Console.WriteLine("Notes of Rs.20 = {0} Notes of Rs.10 = {1} Notes of Rs.5 = {2}", noteCounts[20], noteCounts[10], noteCounts[5]);
            Console.WriteLine("Notes of Rs.2 = {0} Notes of Rs.1 = {1}", noteCounts[2], noteCounts[1]);
            
            Console.ReadLine();
        }
    }
}
