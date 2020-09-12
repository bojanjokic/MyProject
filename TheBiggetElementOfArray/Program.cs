using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBiggetElementOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 5, -9, 6, 5 };

            TheBiggestElement(array);

            Console.ReadKey();
        }

        private static void TheBiggestElement(int[] array)
        {
            Array.Sort(array);

            Array.Reverse(array);

            Console.WriteLine(array[0]);
        }
    }
}
