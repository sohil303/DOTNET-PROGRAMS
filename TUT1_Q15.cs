using System;

namespace CalculatorApplication
{
    public class TUT1_Q15
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int reminder, number, result = 0, original;
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            original = number;
            while (number > 0)
            {
                reminder = number % 10;
                result += reminder * reminder * reminder;
                number /= 10;
            }
            if (original == result)
            {
                Console.WriteLine("This is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("This is not an Armstrong number.");
            }
            Console.ReadLine();
        }
    }
}
