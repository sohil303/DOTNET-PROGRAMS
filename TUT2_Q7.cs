using System;

namespace CalculatorApplication
{
    public class NumberManipulatorQ7
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x; /* save the value of x */
            x = y;   /* put y into x */
            y = temp; /* put temp into y */
        }
    }

    public class TUT2_Q7
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            NumberManipulatorQ7 n = new NumberManipulatorQ7();
            /* local variable definition */
            int a, b;

            Console.WriteLine("Enter value of a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */
            n.swap(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }
    }
}
