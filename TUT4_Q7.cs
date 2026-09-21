// Q7. Find out error code and correct it.
//
// ERROR FOUND & FIXED:
//   "class B : A" → Cannot inherit from sealed class 'A'.
//   A sealed class cannot be used as a base class.
//   Fixed: Removed class B (or remove ':A' if B is needed independently).
//
// The output only uses class A, so class B is removed.

using System;

sealed class A
{
    public int x;
    public int y;
}

// FIXED: Removed "class B : A" because A is sealed and cannot be inherited.
// class B : A   <-- this caused the compile error
// {
//     public int z;
// }

class TUT4_Q7
{
    static void Main()
    {
        A sc = new A();
        sc.x = 110;
        sc.y = 150;
        Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);

        Console.ReadLine();
    }
}
// Output:
// x = 110, y = 150
