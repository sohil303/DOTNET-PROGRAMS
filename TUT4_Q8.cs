// Q8. Find out error code and correct it.
//
// ERRORS FOUND & FIXED:
//   1. Methods were 'protected' → cannot be called from outside the class (Main).
//      Fixed: Changed all protected → public.
//   2. "Obj2.F2();" used BEFORE Obj2 was declared.
//      Fixed: Changed to "Obj1.F2();"
//   3. class Z tried to override sealed method F() from Y → compile error.
//      Fixed: Removed the override of F() in class Z.
//      (Z.F() now calls Y's sealed F, which prints "Y.F")

using System;

class X
{
    public virtual void F()  { Console.WriteLine("X.F");  }  // FIXED: protected → public
    public virtual void F2() { Console.WriteLine("X.F2"); }  // FIXED: protected → public
}

class Y : X
{
    // sealed: no further override of F() allowed in subclasses
    public sealed override void F()  { Console.WriteLine("Y.F");  }  // FIXED: protected → public
    public override void F2() { Console.WriteLine("Y.F2"); }         // FIXED: protected → public
}

class Z : Y
{
    // FIXED: Removed "protected override void F()" — cannot override sealed method F from Y.

    // Overriding F2 is allowed (F2 is not sealed)
    public override void F2() { Console.WriteLine("Z.F2"); }  // FIXED: protected → public
}

class TUT4_Q8
{
    static void Main()
    {
        X Obj1 = new X();
        Obj1.F();
        Obj1.F2();   // FIXED: was "Obj2.F2()" — Obj2 not yet declared at this point

        Y Obj2 = new Y();
        Obj2.F();
        Obj2.F2();

        Z Obj3 = new Z();
        Obj3.F();    // Calls sealed Y.F → prints "Y.F"
        Obj3.F2();   // Calls overridden Z.F2 → prints "Z.F2"

        Console.ReadLine();
    }
}
// Output:
// X.F
// X.F2
// Y.F
// Y.F2
// Y.F
// Z.F2
