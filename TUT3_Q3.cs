using System;

namespace CalculatorApplication
{
    // Define a Student class
    public class Student
    {
        // Private data members
        private int rollNo;
        private string name;
        private string course;

        // Properties
        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        // Default constructor
        public Student()
        {
            rollNo = 0;
            name = "Unknown";
            course = "Not Assigned";
        }

        // Parameterized constructor
        public Student(int rollNo, string name, string course)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.course = course;
        }

        // Method to display student details
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Roll No: {0}, Name: {1}, Course: {2}", rollNo, name, course);
        }
    }

    // Another class called TestStudent within the same .cs file
    public class TestStudent
    {
        public static void RunStudentDemo(string[] args)
        {
            Console.WriteLine("--- Demonstrating Student Class ---");
            
            // Create an object using the default constructor
            Student student1 = new Student();
            Console.WriteLine("Student 1 (Default Constructor):");
            student1.DisplayStudentDetails();

            // Create an object using the parameterized constructor
            Student student2 = new Student(101, "Aarav Patel", "B.Tech Computer Science");
            Console.WriteLine("\nStudent 2 (Parameterized Constructor):");
            student2.DisplayStudentDetails();

            // Modify properties of Student 1
            student1.RollNo = 102;
            student1.Name = "Sneha Sharma";
            student1.Course = "MCA";
            Console.WriteLine("\nStudent 1 after updating Properties:");
            student1.DisplayStudentDetails();
        }
    }

    public class TUT3_Q3
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            TestStudent.RunStudentDemo(null);
            Console.ReadLine();
        }
    }
}
