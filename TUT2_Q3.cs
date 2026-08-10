using System;

namespace ConsoleApplication1
{
    public class TUT2_Q3
    {
        public static void Run()
        {
            string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " " + lastName);

            Console.ReadLine();
        }
    }
}
