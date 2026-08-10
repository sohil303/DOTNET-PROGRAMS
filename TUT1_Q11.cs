using System;

namespace CalculatorApplication
{
    public class TUT1_Q11
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("NAME : ");
            string name = Console.ReadLine();
            Console.Write("GENDER (M/F) : ");
            string gender = Console.ReadLine().Trim().ToUpper();

            if (gender == "M")
            {
                Console.WriteLine("OUTPUT: Mr. " + name);
            }
            else if (gender == "F")
            {
                Console.WriteLine("OUTPUT: Ms. " + name);
            }
            else
            {
                Console.WriteLine("OUTPUT: " + name);
            }
            Console.ReadLine();
        }
    }
}
