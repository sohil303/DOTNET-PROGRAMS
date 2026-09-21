// Q1. Employee class with HRA, DA and Total Pay calculation for 3 employees.

using System;

class Employee
{
    // Data members
    public int    EmpCode;
    public string Name;
    public string Designation;
    public double BasicPay;
    public double HRA;
    public double DA;
    public double TotalPay;

    // Constructor to assign initial values
    public Employee(int code, string name, string designation, double basicPay)
    {
        EmpCode     = code;
        Name        = name;
        Designation = designation;
        BasicPay    = basicPay;
    }

    // Method to calculate HRA, DA and Total Pay
    public void Calculate()
    {
        HRA      = 0.10 * BasicPay;   // 10% of Basic Pay
        DA       = 0.45 * BasicPay;   // 45% of Basic Pay
        TotalPay = BasicPay + HRA + DA;
    }

    // Method to print employee details
    public void Print()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Employee Code : " + EmpCode);
        Console.WriteLine("Name          : " + Name);
        Console.WriteLine("Designation   : " + Designation);
        Console.WriteLine("Basic Pay     : " + BasicPay);
        Console.WriteLine("HRA (10%)     : " + HRA);
        Console.WriteLine("DA  (45%)     : " + DA);
        Console.WriteLine("Total Pay     : " + TotalPay);
        Console.WriteLine("----------------------------------");
    }
}

class TUT4_Q1
{
    static void Main()
    {
        // Create 3 employee objects
        Employee e1 = new Employee(101, "Alice",   "Manager",   50000);
        Employee e2 = new Employee(102, "Bob",     "Developer", 40000);
        Employee e3 = new Employee(103, "Charlie", "Designer",  35000);

        e1.Calculate(); e1.Print();
        e2.Calculate(); e2.Print();
        e3.Calculate(); e3.Print();

        Console.ReadLine();
    }
}
