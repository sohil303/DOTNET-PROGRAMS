using System;

namespace CalculatorApplication
{
    public class SecureEmployee
    {
        private double salary;

        public void SetSalary(double amt, string password)
        {
            if (password == "admin123")
            {
                salary = amt;
                Console.WriteLine("Salary updated successfully.");
            }
            else
            {
                Console.WriteLine("Unauthorized access! Cannot set salary.");
            }
        }

        public double GetSalary(string password)
        {
            if (password == "admin123")
            {
                return salary;
            }
            else
            {
                Console.WriteLine("Unauthorized access! Cannot read salary.");
                return 0;
            }
        }
    }

    public class TUT3_Q14
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            SecureEmployee emp = new SecureEmployee();
            Console.WriteLine("Trying to set salary with wrong password...");
            emp.SetSalary(50000, "wrong");

            Console.WriteLine("\nSetting salary with correct password...");
            emp.SetSalary(50000, "admin123");

            Console.WriteLine("\nTrying to get salary with wrong password...");
            Console.WriteLine("Salary: " + emp.GetSalary("wrong"));

            Console.WriteLine("\nGetting salary with correct password...");
            Console.WriteLine("Salary: " + emp.GetSalary("admin123"));
            Console.ReadLine();
        }
    }
}
