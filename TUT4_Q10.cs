// Q10. Arrange the code to get the desired output.
//
// CHANGES MADE:
//   1. Moved "using System;" to the top.
//   2. MyException constructor takes string and passes it to base Exception.
//   3. catch block prints the exception message using e.Message.
//   4. Removed misplaced constructor body from inside Main class.

using System;  // FIXED: moved to top

class MyException : Exception
{
    // FIXED: Constructor properly defined with base() call
    public MyException(string str) : base(str)
    {
        // passes the message to the base Exception class
    }
}

class TUT4_Q10
{
    public static void Main()
    {
        try
        {
            throw new MyException("my exception generated.");
        }
        catch (Exception e)
        {
            // FIXED: Print the exception message
            Console.WriteLine("Exception caught here: " + e.Message);
        }

        Console.WriteLine("LAST STATEMENT");

        Console.ReadLine();
    }
}
// Output:
// Exception caught here: my exception generated.
// LAST STATEMENT
