using System;

namespace DOTNET_PROGRAMS
{
    public class Pattern3
    {
        public static void Run()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
