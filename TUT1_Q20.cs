using System;

namespace CalculatorApplication
{
    public class TUT1_Q20
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int rows = 4;
            int num = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
