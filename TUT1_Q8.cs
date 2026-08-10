using System;

namespace CalculatorApplication
{
    public class TUT1_Q8
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("INPUT : ");
            string name = Console.ReadLine();
            Console.WriteLine("OUTPUT: " + name.ToUpper());
            Console.ReadLine();
        }
    }
}
