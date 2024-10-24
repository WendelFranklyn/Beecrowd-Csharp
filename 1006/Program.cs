using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1006
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));


            Console.ReadLine();

        }
    }
}
