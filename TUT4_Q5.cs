// Q5. Find out error code and correct it.
//
// ERRORS FOUND & FIXED:
//   1. "A a = A(0);"  → missing 'new' keyword → "A a = new A(0);"
//   2. "B b = B(1);"  → missing 'new' keyword → "B b = new B(1);"

using System;

public class A   // Base class
{
    public A(int value)
    {
        Console.WriteLine("Base constructor A()");
    }
}

public class B : A   // Derived class
{
    public B(int value) : base(value)
    {
        Console.WriteLine("Derived constructor B()");
    }
}

class TUT4_Q5
{
    static void Main()
    {
        A a = new A(0);  // FIXED: added 'new'
        B b = new B(1);  // FIXED: added 'new'

        Console.ReadLine();
    }
}
// Output:
// Base constructor A()
// Base constructor A()
// Derived constructor B()
