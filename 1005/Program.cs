using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
