using System;

namespace CalculatorApplication
{
    public class TUT3_Q4
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("--- Creating and demonstrating 5 Student objects ---");

            // Create an array of 5 Student objects
            Student[] students = new Student[5];

            // Initialize each student with data
            students[0] = new Student(101, "Alice Smith", "Computer Science");
            students[1] = new Student(102, "Bob Jones", "Information Technology");
            students[2] = new Student(103, "Charlie Brown", "Mechanical Engineering");
            students[3] = new Student(104, "Diana Prince", "Electrical Engineering");
            students[4] = new Student(105, "Evan Wright", "Civil Engineering");

            // Display details of each student
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Student {0} - ", i + 1);
                students[i].DisplayStudentDetails();
            }

            Console.ReadLine();
        }
    }
}
