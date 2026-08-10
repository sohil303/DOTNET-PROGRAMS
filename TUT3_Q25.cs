using System;

namespace CalculatorApplication
{
    public class TUT3_Q25
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Enter a password to validate: ");
            string pwd = Console.ReadLine();

            bool hasLength = pwd.Length >= 8;
            bool hasUpperChar = false;
            bool hasLowerChar = false;
            foreach (char c in pwd)
            {
                if (char.IsUpper(c)) hasUpperChar = true;
                if (char.IsLower(c)) hasLowerChar = true;
            }

            if (hasLength && hasUpperChar && hasLowerChar)
            {
                Console.WriteLine("Password is Valid.");
            }
            else
            {
                Console.WriteLine("Password must be at least 8 characters long and contain both uppercase and lowercase letters.");
                
                string modified = pwd.Trim();
                if (modified.Length < 8)
                {
                    modified = modified.PadRight(8, '1');
                }
                modified = char.ToUpper(modified[0]) + modified.Substring(1);
                Console.WriteLine("Suggested safe password: " + modified);
            }
            Console.ReadLine();
        }
    }
}
