//Count occurrences of a given element in an array .
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_PROGRAMS
{
    internal class Occurrences_find
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the element to search: ");
            int target = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] == target)
                {
                    count++;
                }
            }
            Console.WriteLine("Element found " + count + " times.");
        }
    }
}
