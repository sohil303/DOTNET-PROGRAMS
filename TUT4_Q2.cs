// Q2. Complete missing statements and fix errors in Triangle/Shape inheritance.
//
// ERRORS FOUND & FIXED:
//   1. "Triangle t1 new Triangle();" → missing '=' → "Triangle t1 = new Triangle();"
//   2. "Triangle t2 new Triangle();" → missing '=' → "Triangle t2 = new Triangle();"
//
// MISSING STATEMENTS COMPLETED:
//   Missing statement-1: public double Area() method header
//   Missing statement-2: Console.WriteLine("Triangle is " + Style);

using System;

// Base class / Parent class
class Shape
{
    public double Width;
    public double Height;

    public void ShowDim()
    {
        Console.WriteLine("Width and height are " + Width + " and " + Height);
    }
}

// Triangle is derived from Shape (Derived class / Child class)
class Triangle : Shape
{
    public string Style;

    // ---- Missing statement-1 COMPLETED ----
    public double Area()
    {
        return Width * Height / 2;
    }

    // Display a triangle's style.
    public void ShowStyle()
    {
        // ---- Missing statement-2 COMPLETED ----
        Console.WriteLine("Triangle is " + Style);
    }
}

// Driver class
class TUT4_Q2
{
    static void Main()
    {
        Triangle t1 = new Triangle();  // FIXED: added '='
        Triangle t2 = new Triangle();  // FIXED: added '='

        t1.Width  = 4.0;
        t1.Height = 4.0;
        t1.Style  = "isosceles";

        t2.Width  = 8.0;
        t2.Height = 12.0;
        t2.Style  = "right";

        Console.WriteLine("Info for t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Area is " + t1.Area());

        Console.WriteLine();

        Console.WriteLine("Info for t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Area is " + t2.Area());

        Console.ReadLine();
    }
}
// Output:
// Info for t1:
// Triangle is isosceles
// Width and height are 4 and 4
// Area is 8
//
// Info for t2:
// Triangle is right
// Width and height are 8 and 12
// Area is 48
