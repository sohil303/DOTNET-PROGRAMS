using System;

namespace CalculatorApplication
{
    public class Employee
    {
        private string name;
        private double basicSalary;
        private double allowances;
        private double deductions;

        public Employee(string name, double basicSalary, double allowances, double deductions)
        {
            this.name = name;
            this.basicSalary = basicSalary;
            this.allowances = allowances;
            this.deductions = deductions;
        }

        public double CalculateNetSalary()
        {
            return basicSalary + allowances - deductions;
        }

        public void Display()
        {
            Console.WriteLine("Employee: {0}", name);
            Console.WriteLine("Basic Salary: {0}", basicSalary);
            Console.WriteLine("Allowances: {0}", allowances);
            Console.WriteLine("Deductions: {0}", deductions);
            Console.WriteLine("Net Salary: {0}", CalculateNetSalary());
        }
    }

    public class TUT3_Q10
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Basic Salary: ");
            double basic = double.Parse(Console.ReadLine());
            Console.Write("Enter Allowances: ");
            double allow = double.Parse(Console.ReadLine());
            Console.Write("Enter Deductions: ");
            double deduct = double.Parse(Console.ReadLine());

            Employee emp = new Employee(name, basic, allow, deduct);
            Console.WriteLine("\nSalary Details:");
            emp.Display();
            Console.ReadLine();
        }
    }
}
