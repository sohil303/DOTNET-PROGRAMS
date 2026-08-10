using System;

namespace CalculatorApplication
{
    public class CountedStudent
    {
        public static int Count = 0;

        public CountedStudent()
        {
            Count++;
        }
    }

    public class TUT3_Q19
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            CountedStudent s1 = new CountedStudent();
            CountedStudent s2 = new CountedStudent();
            CountedStudent s3 = new CountedStudent();

            Console.WriteLine("Total students created: {0}", CountedStudent.Count);
            Console.ReadLine();
        }
    }
}
