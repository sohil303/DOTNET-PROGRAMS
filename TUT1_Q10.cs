using System;

namespace CalculatorApplication
{
    public class TUT1_Q10
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("INPUT : ");
            string mobile = Console.ReadLine();
            if (mobile.Length >= 5)
            {
                string firstPart = mobile.Substring(0, mobile.Length - 5);
                string output = firstPart + "XXXXX";
                Console.WriteLine("OUTPUT: " + output);
            }
            else
            {
                Console.WriteLine("OUTPUT: XXXXX");
            }
            Console.ReadLine();
        }
    }
}
