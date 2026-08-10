using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_PROGRAMS
{
    internal class Reverce_String
    {
        //Reverse  string
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse: ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            System.Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed string: " + reversedString);
        }
    }
}
