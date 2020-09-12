using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryString;

            while (true)
            {
                Console.WriteLine("Please enter the string value:");
                entryString = Console.ReadLine();

                CheckString(entryString);
            }
        }

        private static void CheckString(string entryString)
        {
            int startIndex = entryString.Length / 2;
            if (entryString != null && entryString.Length > 1)
            {
                if (entryString.Length % 2 == 0)
                {
                    Console.WriteLine("Result: " + entryString.Remove(startIndex - 1, 2));
                }
                else
                {
                    Console.WriteLine("Result: " + entryString.Remove(startIndex, 1));
                }
            }
            else if(entryString != null && entryString.Length == 1)
            {
                Console.WriteLine("Result: " + entryString.Remove(0, 1));
            }
            else
            {
                Console.WriteLine("Enter the correct value.");
            }
        }
    }
}
