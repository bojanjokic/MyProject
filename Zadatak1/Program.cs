using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a function that compares the length of two strings and returns the shorter one.*/
            string firstString = "Valentino";
            string secondString = null;
            DisplayShorterString(CompareStrings(firstString, secondString));
        }

        private static string CompareStrings(string firstString, string secondString)
        {
            try
            {
                if (firstString.Length > 0 || secondString.Length > 0 && secondString != null)
                {
                    if (firstString.Length > secondString.Length)
                    {
                        return secondString;
                    }
                    else if (firstString.Length < secondString.Length)
                    {
                        return firstString;
                    }
                    else
                    {
                        string sameLength = "The length of two strings is the same.";
                        return sameLength;
                    }
                }
            }
            catch (Exception)
            {
                return "Please, entery true values.";
            }

            return "Please, entery true values.";
        }

        private static void DisplayShorterString(string shorterString)
        {
            if (shorterString != null)
            {
                Console.WriteLine(shorterString);
            }
            else
            {
                Console.WriteLine("Error message: We have a error, please try again.");
            }
        }
    }
}
