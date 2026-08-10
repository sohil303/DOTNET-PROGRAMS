using System;

namespace DOTNET_PROGRAMS
{
    public class Pattern1
    {
        public static void Run()
        {
            int num = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num += 2;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
