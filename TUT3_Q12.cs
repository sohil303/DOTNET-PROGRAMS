using System;

namespace CalculatorApplication
{
    public class SimpleStudent
    {
        public string EnrollmentNo { get; set; }
        public string Name { get; set; }
    }

    public class TUT3_Q12
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            SimpleStudent s = new SimpleStudent();
            Console.Write("Enter enrollment number: ");
            s.EnrollmentNo = Console.ReadLine();
            Console.Write("Enter name: ");
            s.Name = Console.ReadLine();

            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Enrollment No: " + s.EnrollmentNo);
            Console.WriteLine("Name: " + s.Name);
            Console.ReadLine();
        }
    }
}
