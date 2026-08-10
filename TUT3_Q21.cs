using System;

namespace CalculatorApplication
{
    public class Parent
    {
        public string FamilyName { get; set; }
        public Parent(string familyName)
        {
            FamilyName = familyName;
        }
    }

    public class Child : Parent
    {
        public string ChildName { get; set; }
        public Child(string childName, string familyName) : base(familyName)
        {
            ChildName = childName;
        }

        public void Display()
        {
            Console.WriteLine("Child: {0} {1}", ChildName, FamilyName);
        }
    }

    public class TUT3_Q21
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Child c = new Child("James", "Smith");
            c.Display();
            Console.ReadLine();
        }
    }
}
