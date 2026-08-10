using System;

namespace CalculatorApplication
{
    public class BaseUser
    {
        public void ShowInfo()
        {
            Console.WriteLine("This is BaseUser info.");
        }
    }

    public class DerivedUser : BaseUser
    {
        // Hiding the base method using 'new' keyword
        public new void ShowInfo()
        {
            Console.WriteLine("This is DerivedUser info (BaseUser info is hidden).");
        }
    }

    public class TUT3_Q22
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            DerivedUser u = new DerivedUser();
            u.ShowInfo(); // Calls derived version
            
            BaseUser bu = u;
            bu.ShowInfo(); // Calls base version
            Console.ReadLine();
        }
    }
}
