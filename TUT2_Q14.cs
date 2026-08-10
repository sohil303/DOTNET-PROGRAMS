using System;

namespace CalculatorApplication
{
    public class TUT2_Q14
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Input the marks obtained in Maths : ");
            int math;
            if (!int.TryParse(Console.ReadLine(), out math))
            {
                Console.WriteLine("Invalid marks.");
                return;
            }

            Console.Write("Input the marks obtained in Physics : ");
            int phy;
            if (!int.TryParse(Console.ReadLine(), out phy))
            {
                Console.WriteLine("Invalid marks.");
                return;
            }

            Console.Write("Input the marks obtained in Chemistry : ");
            int chem;
            if (!int.TryParse(Console.ReadLine(), out chem))
            {
                Console.WriteLine("Invalid marks.");
                return;
            }

            int totalAll = math + phy + chem;
            int totalMathPhy = math + phy;

            bool isEligible = (math >= 65) && (phy >= 55) && (chem >= 50) &&
                              ((totalAll >= 180) || (totalMathPhy >= 140));

            Console.WriteLine("OUTPUT:");
            if (isEligible)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }

            Console.ReadLine();
        }
    }
}
