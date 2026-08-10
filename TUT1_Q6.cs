using System;

namespace ConsoleApplication1_Q6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c, result;
            string str;

            Console.Write("Enter Number   1: ");
            str = Console.ReadLine(); // Missing statement
            a = Convert.ToInt32(str);
 
            Console.Write("Enter Number  2 : ");
            str = Console.ReadLine(); // Missing statement
            b = Convert.ToInt32(str);
 
            Console.Write("Enter Number   3 : ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str); // Missing statement
 
            result = Sum(a, b, c);
            Console.WriteLine("Sum : {0}", result); // Missing statement
           
            Console.Read();
        }
        
        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }
    }
}

namespace CalculatorApplication
{
    public class TUT1_Q6
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            ConsoleApplication1_Q6.Program.Main(null);
        }
    }
}
