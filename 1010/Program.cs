using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1010
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
                int cod1, numPeca1, cod2, numPeca2;
                double valorUni1, valorUni2,total;

                //cod1 = int.Parse(Console.ReadLine());
                //numPeca1 = int.Parse(Console.ReadLine());
                //valorUni1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //cod2 = int.Parse(Console.ReadLine());
                //numPeca2 = int.Parse(Console.ReadLine());
                //valorUni2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                string[] peca1 = Console.ReadLine().Split(' ');
                cod1 = int.Parse(peca1[0]);
                numPeca1 = int.Parse(peca1[1]);
                valorUni1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

                string[] peca2 = Console.ReadLine().Split(' ');
                cod2 = int.Parse(peca2[0]);
                numPeca2 = int.Parse(peca2[1]);
                valorUni2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);



                total = (numPeca1 * valorUni1) + (numPeca2 * valorUni2);

                Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("");


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
