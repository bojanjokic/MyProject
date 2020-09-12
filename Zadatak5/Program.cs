using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a function which check if two strings are Anagram.
            An anagram is a word or phrase formed by rearranging the letters of a different word or phrase.

            Some anagram examples:
            Arc => Car
            Dusty => Study
            The eyes => They see*/
            string string1 = "cArA";
            string string2 = "aRca";
            IsAnagram(string1, string2);
            Console.ReadKey();
        }

        private static void IsAnagram(string string1, string string2)
        {
            if (string1.Length == string2.Length)
            {
                bool isAnagram = false; 
                var str1 = string1.ToLower().ToCharArray();
                var str2 = string2.ToLower().ToCharArray();

                Array.Sort(str1);
                Array.Sort(str2);

                string1 = new string(str1);
                string2 = new string(str2);

                isAnagram = string1.ToString() == string2.ToString();

                if (isAnagram == true)
                {
                    Console.WriteLine("Two strings are Anagram");
                }
                else
                {
                    Console.WriteLine("Two strings are not Anagram");
                }
            }
            else
            {
                Console.WriteLine("Two strings are not Anagram");
            }
        }
    }
}
