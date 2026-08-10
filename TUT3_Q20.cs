using System;

namespace CalculatorApplication
{
    public class ThisDemo
    {
        private int id;
        private string name;

        public ThisDemo(int id, string name)
        {
            // Using 'this' to resolve ambiguity between parameters and fields
            this.id = id;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("ID: {0}, Name: {1}", id, name);
        }
    }

    public class TUT3_Q20
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            ThisDemo demo = new ThisDemo(77, "Self Referenced Object");
            demo.Display();
            Console.ReadLine();
        }
    }
}
