﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1004
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
                int PROD = A * B;

                Console.WriteLine("PROD = " + PROD);

                Console.WriteLine("Aperte Enter para continuar ou digite sair") ;
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