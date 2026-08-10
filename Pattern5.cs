using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_PROGRAMS
{
    internal class Pattern5
    {
        public static void Run()
        {
            int k = 0;

            for (int i = 1; i <= 5; i++) // no of rows
            {
                // calculate value of k for each row
                if (i % 2 == 0)
                    k = k + i - 1;
                else
                    k = k + i;

                for (int j = 1; j <= i; j++) // no of columns
                {
                    Console.Write(k + " ");

                    if (i % 2 == 0)
                        k--;
                    else
                        k++;
                }

                Console.WriteLine();
            }
        }
    }
}
