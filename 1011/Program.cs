using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
                double r, esfera;
                double volume = (4 / 3.0);
                double pi = 3.14159;

                r = double.Parse(Console.ReadLine());

                esfera = (r * r * r) * pi * volume;

                Console.WriteLine("VOLUME = " + esfera.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
