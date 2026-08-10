using System;

namespace ConsoleApplication1
{
    public class TUT2_Q6
    {
        public static void Run(string[] args)
        {
            // Fallback to default arguments if none are passed, to show the desired output
            if (args.Length == 0)
            {
                args = new string[] { "A", "B", "C", "D" };
            }

            Console.WriteLine("Hello, World!");
            Console.WriteLine("You entered the following {0} command line arguments:", args.Length);

            // Loop to print each argument
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            Console.ReadLine();
        }
    }
}
