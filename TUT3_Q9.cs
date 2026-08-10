using System;

namespace CalculatorApplication
{
    public class SimpleClock
    {
        private int hour, min, sec;

        public SimpleClock(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }

        public void Increment()
        {
            sec++;
            if (sec >= 60)
            {
                sec = 0;
                min++;
                if (min >= 60)
                {
                    min = 0;
                    hour++;
                    if (hour >= 24) hour = 0;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Time: {0:D2}:{1:D2}:{2:D2}", hour, min, sec);
        }
    }

    public class TUT3_Q9
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            SimpleClock clock = new SimpleClock(23, 59, 59);
            Console.Write("Original ");
            clock.Display();
            clock.Increment();
            Console.Write("Incremented ");
            clock.Display();
            Console.ReadLine();
        }
    }
}
