using System;

namespace CalculatorApplication
{
    public class TUT2_Q10
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static int matSearch(int[,] mat, int N, int M, int X)
        {
            int row = 0;
            int col = M - 1;

            while (row < N && col >= 0)
            {
                if (mat[row, col] == X)
                {
                    return 1;
                }
                else if (mat[row, col] > X)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }

            return 0;
        }

        public static void Run()
        {
            Console.Write("Enter N (rows): ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid input for N.");
                return;
            }

            Console.Write("Enter M (columns): ");
            int m;
            if (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
            {
                Console.WriteLine("Invalid input for M.");
                return;
            }

            int[,] mat = new int[n, m];
            Console.WriteLine("Enter the matrix row by row (space-separated elements):");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Row {0}: ", i + 1);
                string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Invalid row input.");
                    return;
                }
                string[] tokens = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length < m)
                {
                    Console.WriteLine("Insufficient elements for row {0}. Expected {1}.", i + 1, m);
                    return;
                }
                for (int j = 0; j < m; j++)
                {
                    int val;
                    if (!int.TryParse(tokens[j], out val))
                    {
                        Console.WriteLine("Invalid integer '{0}' at row {1}, col {2}.", tokens[j], i + 1, j + 1);
                        return;
                    }
                    mat[i, j] = val;
                }
            }

            Console.Write("Enter X (element to search): ");
            int x;
            if (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Invalid input for X.");
                return;
            }

            int result = matSearch(mat, n, m, x);
            Console.WriteLine("Output: {0}", result);

            Console.ReadLine();
        }
    }
}
