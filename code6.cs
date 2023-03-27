using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba um número e calcule seu fatorial.

            int entradaUsuario;

            Console.Write("Entre um número para calcular o seu fatorial: ");
            while (!int.TryParse(Console.ReadLine(), out entradaUsuario))
            {
                Console.Write("Entrada inválida! Tente novamente: ");
            }

            Console.Write("O fatorial de {0} é {1}.", entradaUsuario, Fatorial(entradaUsuario));
            Console.WriteLine();
                        
        }

        static int Fatorial(int numeroFatorial)
        {
            int fatorial = 1;
            for (int i = 1; i <= numeroFatorial; i++)
            {
                fatorial *= i;
            }

            return fatorial;
        }

    }

}
