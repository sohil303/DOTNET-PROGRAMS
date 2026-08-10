using System;

namespace DOTNET_PROGRAMS
{
    public class Array
    {
        public static void Run()
        {
            int[] num = new int[5];

            //Task 1: Input an array of 5 elements
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Enter the number: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Task 2: Print the array elements
            for (int i =0; i < num.Length;i++)
            {
                Console.WriteLine("The number is: " + num[i]);
            }
            //Task 3: Find and print sum and avg of all elements
            int sum = 0;
            {
                for (int i = 0; i < num.Length; i++)
                {
                    sum += num[i];
                }
                double avg = (double)sum / num.Length;
                Console.WriteLine("The sum is: " + sum);
                Console.WriteLine("The average is: " + avg);
            }
            //Task 4: Find the minimum and maximum from the array
            int min = num[0];
            int max = num[0];
            {
                for (int i = 1; i < num.Length; i++)
                {
                    if (num[i] < min)
                    {
                        min = num[i];
                    }
                    if (num[i] > max)
                    {
                        max = num[i];
                    }
                }
                Console.WriteLine("The minimum number is: " + min);
                Console.WriteLine("The maximum number is: " + max);
            }
        }
    }
}
