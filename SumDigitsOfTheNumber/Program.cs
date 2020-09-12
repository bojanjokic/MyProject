using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsOfTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5113;

            SumOfDigits(number);
            Console.ReadKey();
        }

        private static void SumOfDigits(int number)
        {
            var num = Convert.ToString(number);
            char[] arrayOfDigits = num.ToCharArray();
            int sum = 0;
            foreach (var digit in arrayOfDigits)
            {
                sum += Convert.ToInt16(digit.ToString());
            }
            Console.WriteLine("Result is:{0}", sum);
        }
    }
}
