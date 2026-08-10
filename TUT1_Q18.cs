using System;

namespace CalculatorApplication
{
    public class TUT1_Q18
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int val = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(val + " ");
                    val++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
