using System;

namespace CalculatorApplication
{
    public class TUT1_Q14
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("INPUT : ");
            string numberStr = Console.ReadLine();
            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            
            Console.Write("OUTPUT: ");
            foreach (char c in numberStr)
            {
                if (char.IsDigit(c))
                {
                    Console.Write(words[c - '0'] + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
