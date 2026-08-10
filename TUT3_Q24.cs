using System;

namespace CalculatorApplication
{
    public sealed class FinalResult
    {
        public string Grade { get; set; }
        public double Percentage { get; set; }

        public FinalResult(string grade, double percentage)
        {
            Grade = grade;
            Percentage = percentage;
        }

        public void Display()
        {
            Console.WriteLine("Grade: {0}, Percentage: {1}%", Grade, Percentage);
        }
    }

    public class TUT3_Q24
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            FinalResult result = new FinalResult("A+", 95.5);
            Console.WriteLine("Final sealed result details:");
            result.Display();
            Console.ReadLine();
        }
    }
}
