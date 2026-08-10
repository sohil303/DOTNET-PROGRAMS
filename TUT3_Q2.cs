using System;

namespace CalculatorApplication
{
    public class Clock
    {
        // Private integer data members
        private int hour;
        private int min;
        private int sec;

        // No-argument constructor
        public Clock()
        {
            this.hour = 12;
            this.min = 0;
            this.sec = 0;
        }

        // Three-argument constructor
        public Clock(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }

        // Increment time to next second
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
                    if (hour >= 24)
                    {
                        hour = 0;
                    }
                }
            }
        }

        // Display the time value
        public void Display()
        {
            Console.WriteLine("Current Time: {0:D2}:{1:D2}:{2:D2}", hour, min, sec);
        }

        // Return the hour
        public int getHour()
        {
            return hour;
        }

        // Return the minute
        public int getMinute()
        {
            return min;
        }

        // Return the seconds
        public int getSeconds()
        {
            return sec;
        }
    }

    public class TUT3_Q2
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("Creating Clock 1 with default constructor (12:00:00):");
            Clock clock1 = new Clock();
            clock1.Display();

            Console.WriteLine("\nCreating Clock 2 with parameters (23:59:58):");
            Clock clock2 = new Clock(23, 59, 58);
            clock2.Display();

            Console.WriteLine("\nIncrementing Clock 2 by 3 seconds:");
            clock2.Increment();
            clock2.Display();
            clock2.Increment();
            clock2.Display();
            clock2.Increment();
            clock2.Display();

            Console.WriteLine("\nUsing getHour(), getMinute(), getSeconds() on Clock 2:");
            Console.WriteLine("Hour: {0}, Minute: {1}, Second: {2}", clock2.getHour(), clock2.getMinute(), clock2.getSeconds());

            Console.ReadLine();
        }
    }
}
