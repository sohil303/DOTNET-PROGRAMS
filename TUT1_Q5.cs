using System;

namespace ConsoleApplication1_Q5
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Declare integers: 'n' for input limit, 'fact' initialized to 1 for product
            int n, fact = 1;
            
            // Output prompt message to the user
            Console.WriteLine("Enter Number : ");
            
            // Read input line from console as string
            string str = Console.ReadLine();
            
            // Convert input string to 32-bit signed integer
            n = Convert.ToInt32(str);
            
            // Loop from 1 up to n (inclusive) to calculate factorial
            for (int i = 1; i <= n; i++)
            {
                // Multiply current product by loop index
                fact = fact * i;
            }
            
            // Print the final calculated factorial value
            Console.WriteLine("Factorial : {0}", fact);
           
            // Wait for user to press enter/read a character
            Console.Read();
        }
    }
}

namespace CalculatorApplication
{
    public class TUT1_Q5
    {
        /*
         * Predicted Output for input 5:
         * Enter Number :
         * 5
         * Factorial : 120
         */
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            ConsoleApplication1_Q5.Program.Main(null);
        }
    }
}
