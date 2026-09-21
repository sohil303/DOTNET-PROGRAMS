
using System;

namespace CalculatorApplication
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public virtual void GenerateSalarySlip()
        {
            Console.WriteLine("Employee Salary Slip");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
        }

        //name must be same as class name

        public Employee()
        {
        }

        public Employee(string Name, double Salary)
        {
            this.Name = Name;
            this.Salary = Salary;
        }

        public double getSalary()
        {
            return Salary;
        }

        public void setSalary(double Salary)
        {
            this.Salary = Salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Sohil", 25000);

            emp.GenerateSalarySlip();

            Console.WriteLine("Get Salary: " + emp.getSalary());

            emp.setSalary(30000);

            Console.WriteLine("Updated Salary: " + emp.getSalary());

            Console.ReadLine();
        }
    }
}
