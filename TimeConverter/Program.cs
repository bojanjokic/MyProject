using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = 100;

            ConvertToTime(seconds);
            Console.ReadKey();
        }

        private static void ConvertToTime(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);

            Console.WriteLine(time.ToString(@"hh\:mm\:ss"));
        }
    }
}
