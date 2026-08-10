using System;

namespace CalculatorApplication
{
    public class TUT1_Q16
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
