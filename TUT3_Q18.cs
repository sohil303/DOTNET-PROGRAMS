using System;

namespace CalculatorApplication
{
   
    // ABSTRACT
    // Abstract means hiding implementation details
    // and showing only necessary information.
    //
    // We need to use the 'abstract' keyword with
    // an abstract class or abstract method.
    //
    // We cannot instantiate (create a direct object)
    // of an abstract class.
    //
    // An abstract class will work as a parent class
    // for other classes.
    //
    // It is expected to add abstract methods in
    // an abstract class.
    //
    // An abstract class may have non-abstract methods.
    //
    // A subclass must implement all abstract methods
    // of the parent class.
    //
    // Gujarati:
    // Abstract class નો direct object બનાવી શકાતો નથી.
    // તે parent class તરીકે કામ કરે છે.
    // Child class એ parent ની બધી abstract methods
    // implement કરવી compulsory છે.
    // ============================================================


    // Abstract Class
    // 'abstract' keyword is used with the class.
    public abstract class Employee_Q18
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public double HRA { get; set; }
        public double DA { get; set; }


        // Constructor
        public Employee_Q18(
            string name,
            double salary,
            double hra,
            double da)
        {
            Name = name;
            Salary = salary;
            HRA = hra;
            DA = da;
        }


        // ========================================================
        // ABSTRACT METHOD
        // ========================================================
        //
        // 'abstract' keyword is used with the method.
        //
        // Abstract method does NOT have a body.
        //
        // It only contains method declaration.
        //
        // Child class must implement this method
        // using the 'override' keyword.
        //
        // Gujarati:
        // Abstract method માં body નથી હોતી.
        // Child class માં override કરીને તેની body લખવી પડે.
        // ========================================================

        public abstract void GenerateSalarySlip();


        // ========================================================
        // NON-ABSTRACT METHOD
        // ========================================================
        //
        // An abstract class may have non-abstract methods.
        //
        // Non-abstract method has a complete body.
        //
        // Gujarati:
        // Abstract class માં normal/non-abstract method પણ
        // રાખી શકાય છે.
        // ========================================================

        public void DisplayEmployee()
        {
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Basic Salary  : " + Salary);
        }
    }


    // ============================================================
    // SUB CLASS / CHILD CLASS
    // ============================================================
    //
    // PermanentEmployee inherits Employee_Q18.
    //
    // Since Employee_Q18 contains an abstract method,
    // PermanentEmployee MUST implement it.
    //
    // We use 'override' keyword to implement the
    // abstract method of the parent class.
    // ============================================================

    class PermanentEmployee_Q18 : Employee_Q18
    {
        // Constructor of child class
        //
        // ': base(...)' calls the constructor
        // of the parent class.
        public PermanentEmployee_Q18(
            string name,
            double salary,
            double hra,
            double da)
            : base(name, salary, hra, da)
        {
        }


        // ========================================================
        // IMPLEMENTATION OF ABSTRACT METHOD
        // ========================================================
        //
        // Parent class:
        // public abstract void GenerateSalarySlip();
        //
        // Child class:
        // public override void GenerateSalarySlip()
        //
        // 'override' means we are providing the implementation
        // of the parent's abstract method.
        // ========================================================

        public override void GenerateSalarySlip()
        {
            double hraAmount = Salary * HRA;
            double daAmount = Salary * DA;
            double netSalary = Salary + hraAmount + daAmount;

            Console.WriteLine("Permanent Employee Salary Slip");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Basic Salary  : " + Salary);
            Console.WriteLine("HRA           : " + hraAmount);
            Console.WriteLine("DA            : " + daAmount);
            Console.WriteLine("Net Salary    : " + netSalary);
        }
    }


    // ============================================================
    // SECOND SUB CLASS / CHILD CLASS
    // ============================================================
    //
    // ContractEmployee also inherits Employee_Q18.
    //
    // It MUST implement GenerateSalarySlip()
    // because it is an abstract method of the parent class.
    // ============================================================

    class ContractEmployee_Q18 : Employee_Q18
    {
        // Constructor
        public ContractEmployee_Q18(
            string name,
            double salary,
            double hra,
            double da)
            : base(name, salary, hra, da)
        {
        }


        // ========================================================
        // OVERRIDE ABSTRACT METHOD
        // ========================================================

        public override void GenerateSalarySlip()
        {
            Console.WriteLine("Contract Employee Salary Slip");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Basic Salary  : " + Salary);
        }
    }


    // ============================================================
    // MAIN CLASS
    // ============================================================

    class Tut3_Q18
    {
        static void Main()
        {
            // ====================================================
            // We CANNOT create direct object of abstract class.
            //
            // This is NOT allowed:
            //
            // Employee_Q18 emp = new Employee_Q18(...);
            //
            // Because Employee_Q18 is an abstract class.
            // ====================================================


            // ====================================================
            // Creating object of PermanentEmployee child class
            // ====================================================

            PermanentEmployee_Q18 emp =
                new PermanentEmployee_Q18(
                    "Sohil",
                    50000,
                    0.2,
                    0.1);

            // Calling abstract method implementation
            emp.GenerateSalarySlip();

            Console.WriteLine();


            // ====================================================
            // Creating object of ContractEmployee child class
            // ====================================================

            ContractEmployee_Q18 emp2 =
                new ContractEmployee_Q18(
                    "Arva",
                    40000,
                    0.2,
                    0.1);

            // Calling abstract method implementation
            emp2.GenerateSalarySlip();

            Console.WriteLine();


            // Calling non-abstract method
            // from the abstract parent class.
            emp.DisplayEmployee();

            Console.ReadLine();
        }
    }
}






/* -- Employee class
 * abstracct public void show();
 * dose not have any implementation
 * all the abstract methods are by default virtual
 -- Regular employee class
public override void show()
{
    Console.WriteLine("Show method for regular employee");
}

main method 
employee.4()
employee .5()*/

// interface
class RegularEmployee : Employee, ISalary,Itest

 /* It suggest that "what a class must do but not how it is does"
 mens an interface will provide a list of methodes and 
a class must implement all the methods 
* interface may have non abstract methods
* we can not add non abstract methods in interface*/

//a class can implement more than one interface 

/*Regular employee class
private double GrossSalary;
private double NetSalary;*/

/*private void claulateSalary()
  {
    GrossSalary = BasicSalary + HRA + DA;
    NetSalary = GrossSalary - pf - pt ;
}
*/