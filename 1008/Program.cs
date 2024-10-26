using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int funcionario, horas;
            double valorHora, salario;

            funcionario = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valorHora;
            Console.WriteLine("NUMBER = " + funcionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();

        }
    }
}
