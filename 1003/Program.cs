using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003
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
                int A = int.Parse(Console.ReadLine());
                int B = int.Parse(Console.ReadLine());
                int SOMA = A + B;

                Console.WriteLine("SOMA = " + SOMA);

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
