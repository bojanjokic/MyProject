using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a function that finds only odd numbers in a given array and prints them out to console. 
             * If there are no odd numbers, print out a meaningful message to the user.
            (Example: array {-2,-1, 5, -6}, result is: {-1,5})*/

            int[] numbers = { -2, -1, 5, -6 };
            FindOddNumbers(numbers);
        }

        private static void FindOddNumbers(int[] numbers)
        {
            bool numberIsOdd = false;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                    numberIsOdd = true;
                }
            }
            if (numberIsOdd == false)
            {
                Console.WriteLine("The Array does not contain odd numbers.");
            }
        }
    }
}
