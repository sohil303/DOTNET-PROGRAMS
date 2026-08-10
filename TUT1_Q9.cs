using System;

namespace CalculatorApplication
{
    public class TUT1_Q9
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("INPUT : ");
            string name = Console.ReadLine();
            char[] chars = name.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                {
                    chars[i] = char.ToLower(chars[i]);
                }
                else if (char.IsLower(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                }
            }
            Console.WriteLine("OUTPUT: " + new string(chars));
            Console.ReadLine();
        }
    }
}
