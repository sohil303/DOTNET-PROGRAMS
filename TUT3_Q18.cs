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
        }
    }

    //Derived class 

    class PermanentEmployee : Employee
    {
        public override void GenerateSalarySlip()
        {
            double hra = Salary * 0.2;
            double da = Salary * 0.1;
            double netSalary = Salary + hra + da;

            Console.WriteLine("Permanent Employee Salary Slip");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Basic Salary  : " + Salary);
            Console.WriteLine("HRA           : " + hra);
            Console.WriteLine("DA            : " + da);
            Console.WriteLine("Net Salary    : " + netSalary);
        }
    }

    //Derived class

    class ContractEmployee : Employee
    {
        public override void GenerateSalarySlip()
        {
            Console.WriteLine("Contract Employee Salary Slip");
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Basic Salary  : " + Salary);
        }
    }

    class Tut3_Q18
    {
        static void Main()
        {
            PermanentEmployee emp = new PermanentEmployee();

            emp.Name = "Sohil";
            emp.Salary = 50000;

            emp.GenerateSalarySlip();

            ContractEmployee emp2 = new ContractEmployee();

            emp2.Name = "Arva";
            emp2.Salary = 40000;

            emp2.GenerateSalarySlip();
        }
    }
}