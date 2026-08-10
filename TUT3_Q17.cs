using System;

namespace CalculatorApplication
{
    public class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double r) { Radius = r; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double w, double h) { Width = w; Height = h; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class TUT3_Q17
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Shape circle = new Circle(5);
            Shape rect = new Rectangle(4, 6);

            Console.WriteLine("Area of Circle: {0:F2}", circle.CalculateArea());
            Console.WriteLine("Area of Rectangle: {0}", rect.CalculateArea());
            Console.ReadLine();
        }
    }
}
