using System;

namespace CalculatorApplication
{
    public class StudentDetail
    {
        private string name;
        private int age;
        private string grade;

        public StudentDetail(string name, int age, string grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2}", name, age, grade);
        }
    }

    public class TUT3_Q8
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            {
                Console.Write("Invalid age. Enter student age again: ");
            }
            Console.Write("Enter student grade: ");
            string grade = Console.ReadLine();

            StudentDetail s = new StudentDetail(name, age, grade);
            Console.WriteLine("\nStudent Details:");
            s.Display();
            Console.ReadLine();
        }
    }
}
