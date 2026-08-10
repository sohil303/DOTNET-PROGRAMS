using System;

namespace CalculatorApplication
{
    public class TUT1_Q3
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter Number: ");
            if (int.TryParse(Console.ReadLine(), out int x))
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is Odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.ReadLine();
        }
    }
}
