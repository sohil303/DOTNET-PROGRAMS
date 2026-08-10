using System;

namespace CalculatorApplication
{
    public class TUT3_Q26
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter customer raw name (e.g. '   mr. john_doe   '): ");
            string nameInput = Console.ReadLine();

            // 1. Trimming
            string trimmed = nameInput.Trim();

            // 2. Replacing
            string replaced = trimmed.Replace('_', ' ');

            // 3. Convert Case
            string uppercased = replaced.ToUpper();

            // 4. Inserting
            string formatted = uppercased;
            if (!uppercased.Contains("DEAR"))
            {
                formatted = uppercased.Insert(0, "DEAR ");
            }

            Console.WriteLine("Processed Name: " + formatted);
            Console.ReadLine();
        }
    }
}
