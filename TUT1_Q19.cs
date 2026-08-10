using System;

namespace CalculatorApplication
{
    public class TUT1_Q19
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
