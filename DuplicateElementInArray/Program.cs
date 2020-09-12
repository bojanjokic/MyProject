using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 3, 5, 3, 6 };
            RemoveDuplicateElements(array);
        }

        private static void RemoveDuplicateElements(int[] array)
        {
            int[] newArray = array.Distinct().ToArray();

            foreach (var element in newArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
