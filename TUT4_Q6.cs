// Q6. Find out error code and correct it.
//
// ERRORS FOUND & FIXED:
//   1. "int a;"          → private field, not accessible via base.a in derived classes
//      Fixed to: "protected int a;"
//   2. "abstract void A();" → abstract method must be public or protected
//      Fixed to: "public abstract void A();"

using System;

abstract class Test
{
    protected int a;          // FIXED: was "int a" (private) → changed to protected

    public abstract void A(); // FIXED: was "abstract void A()" → added public
}

class Example1 : Test
{
    public override void A()
    {
        Console.WriteLine("Example1.A");
        base.a++;
    }
}

class Example2 : Test
{
    public override void A()
    {
        Console.WriteLine("Example2.A");
        base.a--;
    }
}

class TUT4_Q6
{
    static void Main()
    {
        Test test1 = new Example1();
        test1.A();

        Test test2 = new Example2();
        test2.A();

        Console.ReadLine();
    }
}
// Output:
// Example1.A
// Example2.A
