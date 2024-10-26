using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                //a) a área do triângulo retângulo que tem A por base e C por altura.
                //b) a área do círculo de raio C. (pi = 3.14159)
                //c) a área do trapézio que tem A e B por bases e C por altura.
                //d) a área do quadrado que tem lado B.
                //e) a área do retângulo que tem lados A e B.

                string[] area = Console.ReadLine().Split(' ');
                double A = double.Parse(area[0], CultureInfo.InvariantCulture);
                double B = double.Parse(area[1], CultureInfo.InvariantCulture);
                double C = double.Parse(area[2], CultureInfo.InvariantCulture);

                Console.WriteLine("TRIANGULO: " + (A * C/2).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("CIRCULO: " + (3.14159 * C * C).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("TRAPEZIO: " + ((A + B) * C/2).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("QUADRADO: " + (B * B).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("RETANGULO: " + (A * B).ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
