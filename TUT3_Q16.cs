using System;

namespace CalculatorApplication
{
    public class Staff
    {
        public string Name { get; set; }
        public double BasicSalary { get; set; }
    }

    public class Manager : Staff
    {
        public double Allowance { get; set; }
        public double CalculateSalary()
        {
            return BasicSalary + Allowance;
        }
    }

    public class Clerk : Staff
    {
        public double Bonus { get; set; }
        public double CalculateSalary()
        {
            return BasicSalary + Bonus;
        }
    }

    public class TUT3_Q16
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Manager m = new Manager { Name = "Alice", BasicSalary = 60000, Allowance = 15000 };
            Clerk c = new Clerk { Name = "Bob", BasicSalary = 25000, Bonus = 3000 };

            Console.WriteLine("Manager: {0}, Total Salary: {1}", m.Name, m.CalculateSalary());
            Console.WriteLine("Clerk: {0}, Total Salary: {1}", c.Name, c.CalculateSalary());
            Console.ReadLine();
        }
    }
}
