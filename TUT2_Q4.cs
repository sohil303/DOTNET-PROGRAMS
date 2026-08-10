using System;

namespace ConsoleApplication1
{
    public class TUT2_Q4
    {
        public static void Run()
        {
            Console.Write("Enter first number (A): ");
            string inputA = Console.ReadLine();
            Console.Write("Enter second number (B): ");
            string inputB = Console.ReadLine();

            if (double.TryParse(inputA, out double numA) && double.TryParse(inputB, out double numB))
            {
                Console.WriteLine("\n--- Data Types Demonstration ---");
                int integerA = (int)numA;
                int integerB = (int)numB;
                bool isAGreaterThanB = numA > numB;
                string relationResult = isAGreaterThanB ? "A is greater than B" : "A is not greater than B";

                Console.WriteLine($"Double Type values: A = {numA}, B = {numB}");
                Console.WriteLine($"Integer Type values (casted): A = {integerA}, B = {integerB}");
                Console.WriteLine($"Boolean Type value (A > B): {isAGreaterThanB}");
                Console.WriteLine($"String Type relation: {relationResult}");

                Console.WriteLine("\n--- Arithmetic Operations ---");
                Console.WriteLine($"Addition (A + B): {numA + numB}");
                Console.WriteLine($"Subtraction (A - B): {numA - numB}");
                Console.WriteLine($"Multiplication (A * B): {numA * numB}");
                if (numB != 0)
                {
                    Console.WriteLine($"Division (A / B): {numA / numB}");
                    Console.WriteLine($"Modulo (A % B): {numA % numB}");
                }
                else
                {
                    Console.WriteLine("Division and Modulo by zero are not allowed.");
                }

                Console.WriteLine("\n--- Relational Operations ---");
                Console.WriteLine($"Is Equal (A == B): {numA == numB}");
                Console.WriteLine($"Is Not Equal (A != B): {numA != numB}");
                Console.WriteLine($"Is Less Than (A < B): {numA < numB}");

                Console.WriteLine("\n--- Logical Operations ---");
                bool condition1 = numA > 0;
                bool condition2 = numB > 0;
                Console.WriteLine($"Is A positive? (A > 0): {condition1}");
                Console.WriteLine($"Is B positive? (B > 0): {condition2}");
                Console.WriteLine($"Both positive? (A > 0 && B > 0): {condition1 && condition2}");
                Console.WriteLine($"At least one positive? (A > 0 || B > 0): {condition1 || condition2}");
                Console.WriteLine($"Is A NOT positive? !(A > 0): {!condition1}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numeric values.");
            }

            Console.ReadLine();
        }
    }
}
