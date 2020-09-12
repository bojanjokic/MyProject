using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircumferenceOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 5;

            CircumferenceOfACircle(r);

            Console.ReadKey();
        }

        private static void CircumferenceOfACircle(double r)
        {
            double circleCircumference = r*r * Math.PI;
            Console.WriteLine("Result is: " + circleCircumference);
        }
    }
}
