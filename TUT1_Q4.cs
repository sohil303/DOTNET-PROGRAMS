using System;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter Number : ");
            string str = Console.ReadLine();
            x = Convert.ToInt32(str);
            if (x % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.Read();
        }
    }
}

namespace CalculatorApplication
{
    public class TUT1_Q4
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            ConsoleApplication1.Program.Main(args);
        }
    }
}
