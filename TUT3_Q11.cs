using System;

namespace CalculatorApplication
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string OwnerName { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(string accNum, string owner, double initialBalance)
        {
            AccountNumber = accNum;
            OwnerName = owner;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposited {0} to Account {1}. New Balance: {2}", amount, AccountNumber, Balance);
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds in Account {0}!", AccountNumber);
            }
            else if (amount > 0)
            {
                Balance -= amount;
                Console.WriteLine("Withdrew {0} from Account {1}. New Balance: {2}", amount, AccountNumber, Balance);
            }
        }

        public void Enquiry()
        {
            Console.WriteLine("Account: {0} | Owner: {1} | Balance: {2}", AccountNumber, OwnerName, Balance);
        }
    }

    public class TUT3_Q11
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            BankAccount acc1 = new BankAccount("ACC001", "Alice", 1000);
            BankAccount acc2 = new BankAccount("ACC002", "Bob", 500);

            acc1.Enquiry();
            acc2.Enquiry();

            acc1.Deposit(500);
            acc2.Withdraw(200);

            acc1.Enquiry();
            acc2.Enquiry();
            Console.ReadLine();
        }
    }
}
