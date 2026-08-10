using System;

namespace CalculatorApplication
{
    public class TUT1_Q13
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int n = 11; // Terms needed to reach 55
            int a = 0, b = 1;
            Console.Write(a + " " + b + " ");
            for (int i = 3; i <= n; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
