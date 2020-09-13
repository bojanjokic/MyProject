using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeElementsValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //izmena nova koja se desila
            int[] array = { -4, 5, -3, 4, -5, -4, -2 };

            ChangeElementsValue(array);

            Console.ReadKey();
        }

        private static void ChangeElementsValue(int[] array)
        {
            int x = 0;
            int y = 0;

            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) == 4)
                {
                    newArray[(array.Length - 1) - x] = 0;
                    x++;
                }
                else
                {
                    newArray[y] = array[i];
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
