using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a function that receives a list of strings and joins them into a single string, separated by white space.
            (Example: for list {"hello","wo", "rld"}), result is "hello wo rld".*/
            List<string> listOfStrings = new List<string>()
            {
                "hello",
                "wo",
                "rdl"
            };
            ReturnSingleString(listOfStrings);
            Console.ReadKey();
        }

        private static void ReturnSingleString(List<string> listOfStrings)
        {
            StringBuilder newString = new StringBuilder();
            foreach (var word in listOfStrings)
            {
                newString.Append(" " + word);
            }
            Console.WriteLine(newString.ToString().TrimStart());
        }
    }
}
