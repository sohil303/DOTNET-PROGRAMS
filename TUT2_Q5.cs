using System;

namespace ConsoleApplication1
{
    public class TUT2_Q5
    {
        public static void Run()
        {
            int[] arr = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                while (!int.TryParse(str, out arr[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("Enter Element {0}: ", i);
                    str = Console.ReadLine();
                }
            }

            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of Elements : {0}", sum);
            Console.Read();
        }
    }
}
