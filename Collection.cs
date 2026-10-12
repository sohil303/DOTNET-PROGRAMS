using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_PROGRAMS
{
    class Collection
    {
        static void Main(string[] args)
        {
            // Creating object collection
            ArrayList obj = new ArrayList();

            // Adding elements into a collection
            obj.Add("RKU");
            obj.Add(110);
            obj.Add(152.85);
            obj.Add('X');
            obj.Add(true);

            // Fetching the number of elements in a collection
            Console.WriteLine("Number of Elements: " + obj.Count);

            // Removing an element by value from a collection
            obj.Remove("RKU");

            // Traversing collection element by element
            foreach (object str in obj)
            {
                Console.WriteLine(str + "____");
            }

            Console.ReadKey();
        }
    }
}
