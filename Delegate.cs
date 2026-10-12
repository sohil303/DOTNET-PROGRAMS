using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_PROGRAMS
{
    // Delegate declaration
    delegate void MyDelegate(int x, int y);

    class Delegate
    {
        // Addition method
        static void Add(int x, int y)
        {
            Console.WriteLine("Addition = " + (x + y));
        }

        // Subtraction method
        static void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction = " + (x - y));
        }

        // Multiplication method
        static void Mul(int x, int y)
        {
            Console.WriteLine("Multiplication = " + (x * y));
        }

        // Division method
        static void Div(int x, int y)
        {
            Console.WriteLine("Division = " + (x / y));
        }

        static void Main(string[] args)
        {
            // Create delegate object and assign Add method
            MyDelegate obj = new MyDelegate(Add);

            // Add Sub method
            obj += new MyDelegate(Sub);

            // Add Mul method
            obj += Mul;

            // Add Div method
            obj += Div;

            // Invocation
            obj(10, 5);

            // Wait for user input
            Console.Read();
        }
    }
}
