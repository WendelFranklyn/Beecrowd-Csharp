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
            string input = "";
            //"Enquanto o texto digitado não for 'Sair' (ignorando maiúsculas e minúsculas),
            //o programa pedirá para digitar um número. Se for digitada a palavra 'Sair',
            //o programa encerrará e não pedirá mais números."
            while (!input.Equals("Sair", StringComparison.OrdinalIgnoreCase))
            {
                int funcionario, horas;
                double valorHora, salario;

                funcionario = int.Parse(Console.ReadLine());
                horas = int.Parse(Console.ReadLine());
                valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                salario = horas * valorHora;
                Console.WriteLine("NUMBER = " + funcionario);
                Console.WriteLine("SALARY = U$ " + salario.ToString("F2",CultureInfo.InvariantCulture));

                Console.WriteLine("Aperte Enter para continuar ou digite sair");
                Console.ReadLine();

                //input = Console.ReadLine();

                if (input.Equals("Sair", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                Console.Clear();
            }
        }
    }
}
