// Q4. Complete missing statements and fix errors in StaticVar.
//
// ERRORS FOUND & FIXED:
//   1. "public counting()" → wrong method name & missing return type
//      Fixed to: "public void count()"
//
// MISSING STATEMENT COMPLETED:
//   public static int getNum() { return num; }

using System;

namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;

        // FIXED: was "public counting()" → renamed to count() and added void
        public void count()
        {
            num++;
        }

        // ---- Missing statement COMPLETED ----
        public static int getNum()
        {
            return num;
        }
    }

    class TUT4_Q4
    {
        static void Main(string[] args)
        {
            StaticVar s = new StaticVar();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("Variable num: {0}", StaticVar.getNum());
            Console.ReadKey();
        }
    }
}
// Output:
// Variable num: 3
