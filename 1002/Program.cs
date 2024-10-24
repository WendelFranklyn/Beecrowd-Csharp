using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = n * (raio * raio);
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
