using System;

namespace While_Loop
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1, res, i;
 
            Console.WriteLine("Enter a number");
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            i = 1; //Initialization

            //Check whether condition matches or not
            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);

                i++; //Increment by one
            }
            Console.ReadLine();           
        }
    }
}

namespace CalculatorApplication
{
    public class TUT1_Q7
    {
        /*
         * Predicted Output for input 5:
         * Enter a number
         * 5
         * 5 x 1 = 5
         * 5 x 2 = 10
         * 5 x 3 = 15
         * 5 x 4 = 20
         * 5 x 5 = 25
         * 5 x 6 = 30
         * 5 x 7 = 35
         * 5 x 8 = 40
         * 5 x 9 = 45
         * 5 x 10 = 50
         */
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            While_Loop.Program.Main(null);
        }
    }
}
