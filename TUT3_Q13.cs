using System;

namespace CalculatorApplication
{
    public class ProductDetails
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double CalculateBill()
        {
            return Price * Quantity;
        }
    }

    public class TUT3_Q13
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            ProductDetails prod = new ProductDetails();
            Console.Write("Enter Product Name: ");
            prod.ProductName = Console.ReadLine();
            Console.Write("Enter Price: ");
            prod.Price = double.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            prod.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- BILL RECEIPT ---");
            Console.WriteLine("Product: {0}", prod.ProductName);
            Console.WriteLine("Price: {0}", prod.Price);
            Console.WriteLine("Quantity: {0}", prod.Quantity);
            Console.WriteLine("Total Bill Amount: {0}", prod.CalculateBill());
            Console.ReadLine();
        }
    }
}
