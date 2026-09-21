// Q9. Add try, catch and finally blocks to handle DivideByZeroException.

using System;

class TUT4_Q9
{
    public static void Main()
    {
        int x   = 0;
        int div = 0;

        try
        {
            div = 100 / x;           // This throws DivideByZeroException
            Console.WriteLine(div);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        Console.ReadLine();
    }
}
// Output:
// Cannot divide by zero.
// Finally block executed.
