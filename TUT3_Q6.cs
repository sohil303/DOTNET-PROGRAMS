using System;

namespace LineApplication
{
    class Line
    {
        private double length;   // Length of a line

        public Line()
        {
            length = 10.0;
            Console.WriteLine("Object is being created, length = 10");
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }
    }

    class TestLine
    {
        public static void RunLineDemo(string[] args)
        {
            Line line = new Line();   
            // set line length
            Console.WriteLine("Length of line : {0}", line.getLength());
            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
        }
    }
}

namespace CalculatorApplication
{
    public class TUT3_Q6
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            LineApplication.TestLine.RunLineDemo(null);
            Console.ReadLine();
        }
    }
}
