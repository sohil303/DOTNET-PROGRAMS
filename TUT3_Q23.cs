using System;

namespace CalculatorApplication
{
    public abstract class Account
    {
        public double Balance { get; set; }
        public Account(double balance) { Balance = balance; }
        public abstract double CalculateInterest();
    }

    public class SavingsAccount : Account
    {
        public SavingsAccount(double bal) : base(bal) { }
        public override double CalculateInterest()
        {
            return Balance * 0.04; // 4% interest
        }
    }

    public class CurrentAccount : Account
    {
        public CurrentAccount(double bal) : base(bal) { }
        public override double CalculateInterest()
        {
            return Balance * 0.01; // 1% interest
        }
    }

    public class TUT3_Q23
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Account sa = new SavingsAccount(10000);
            Account ca = new CurrentAccount(10000);

            Console.WriteLine("Savings Account Interest: {0}", sa.CalculateInterest());
            Console.WriteLine("Current Account Interest: {0}", ca.CalculateInterest());
            Console.ReadLine();
        }
    }
}
