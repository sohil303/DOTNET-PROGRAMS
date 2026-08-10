using System;

namespace CalculatorApplication
{
    class Product
    {
        // Data members
        int pcode;
        string pname, mname;

        // Constructor
        public Product(int pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("Product Code:= P" + pcode.ToString("D3"));
            Console.WriteLine("Product Name:= " + pname);
            Console.WriteLine("Manufacturer Name:= " + mname);
        }
    }

    public class TestProduct
    {
        public static void RunProductDemo(string[] args)
        {
            // If run with arguments (e.g. [csc TestProduct ProductCode ProductName Manufacturer])
            if (args != null && args.Length >= 3)
            {
                int pcd = 1;
                string arg0 = args[0].ToUpper();
                if (arg0.StartsWith("P"))
                {
                    int.TryParse(arg0.Substring(1), out pcd);
                }
                else
                {
                    int.TryParse(args[0], out pcd);
                }
                string pnm = args[1];
                string mnm = args[2];

                Product p = new Product(pcd, pnm, mnm);
                p.Display();
            }
            else
            {
                // Fallback / default values to produce the exact requested output
                int pcd = 1;
                string pnm = "Mouse";
                string mnm = "Logitech";
                Product p = new Product(pcd, pnm, mnm);
                p.Display();
            }
        }
    }

    public class TUT3_Q5
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            TestProduct.RunProductDemo(null);
            Console.ReadLine();
        }
    }
}
