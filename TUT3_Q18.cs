using System;

namespace CalculatorApplication
{
    public class EmployeeSlip
    {
        public string Name { get; set; }
        public double Basic { get; set; }

        public EmployeeSlip(string name, double basic)
        {
            Name = name;
            Basic = basic;
        }

        public virtual double CalculateNetSalary()
        {
            return Basic;
        }
    }

    public class PermanentEmployee : EmployeeSlip
    {
        public double Pf { get; set; }
        public PermanentEmployee(string name, double basic, double pf) : base(name, basic)
        {
            Pf = pf;
        }

        public override double CalculateNetSalary()
        {
            return Basic - Pf;
        }
    }

    public class ContractEmployee : EmployeeSlip
    {
        public double ServiceTax { get; set; }
        public ContractEmployee(string name, double basic, double tax) : base(name, basic)
        {
            ServiceTax = tax;
        }

        public override double CalculateNetSalary()
        {
            return Basic - ServiceTax;
        }
    }

    public class TUT3_Q18
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            EmployeeSlip p = new PermanentEmployee("John", 50000, 4000);
            EmployeeSlip c = new ContractEmployee("Sarah", 35000, 2000);

            Console.WriteLine("Permanent Employee: {0}, Net Salary: {1}", p.Name, p.CalculateNetSalary());
            Console.WriteLine("Contract Employee: {0}, Net Salary: {1}", c.Name, c.CalculateNetSalary());
            Console.ReadLine();
        }
    }
}
