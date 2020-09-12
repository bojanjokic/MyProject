using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayFirstOddNumbersFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 6, 9, 8 };

            ReturnFirstOddNumbers1(array);
            Console.WriteLine("--------------------------------------------------------------------");
            ReturnFirstOddNumbers2(array);

            Console.ReadKey();
        }

        private static void ReturnFirstOddNumbers2(int[] array)
        {
            List<int> oddElements = new List<int>();
            List<int> evenElements = new List<int>();

            foreach (var element in array)
            {
                if (element % 2 == 0)
                {
                    evenElements.Add(element);
                }
                else
                {
                    oddElements.Add(element);
                }
            }
            List<int> allElements = new List<int>(evenElements.Concat(oddElements));

            foreach (var element in allElements)
            {
                Console.WriteLine(element);
            }
        }

        private static void ReturnFirstOddNumbers1(int[] array)
        {
            int[] newArray = new int[array.Length];
            int x = 0;
            int y = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    newArray[x] = array[i];
                    x++;
                }
                else
                {
                    newArray[(array.Length - 1) - y] = array[i];
                    y++;
                }
            }

            foreach (var element in newArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
