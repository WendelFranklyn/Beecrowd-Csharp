using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1009
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
                string nome = Console.ReadLine();
                double salario, totalvendas,comissao, total;

                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                totalvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                comissao = totalvendas * 0.15;

                total = salario + comissao;

                Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

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
