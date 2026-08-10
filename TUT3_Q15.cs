using System;

namespace CalculatorApplication
{
    public class PersonInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayPerson()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
        }
    }

    public class CollegeStudent : PersonInfo
    {
        public string RollNo { get; set; }
        public string Course { get; set; }

        public void DisplayStudent()
        {
            DisplayPerson();
            Console.WriteLine("Roll No: {0}", RollNo);
            Console.WriteLine("Course: {0}", Course);
        }
    }

    public class TUT3_Q15
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            CollegeStudent s = new CollegeStudent();
            s.Name = "Ravi Kumar";
            s.Age = 20;
            s.RollNo = "CS021";
            s.Course = "BCA";

            Console.WriteLine("Complete Student Details:");
            s.DisplayStudent();
            Console.ReadLine();
        }
    }
}
