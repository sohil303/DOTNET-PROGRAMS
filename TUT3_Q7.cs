using System;

namespace CalculatorApplication
{
    public class StudentQ7
    {
        private string enrolmentNo;
        private string name;

        public string EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public StudentQ7()
        {
            enrolmentNo = "N/A";
            name = "Unknown";
        }

        public StudentQ7(string enrolmentNo, string name)
        {
            this.enrolmentNo = enrolmentNo;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Enrollment No: {0}, Name: {1}", enrolmentNo, name);
        }
    }

    public class TUT3_Q7
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            StudentQ7 s1 = new StudentQ7("EN001", "John Doe");
            s1.Display();
            Console.ReadLine();
        }
    }
}
