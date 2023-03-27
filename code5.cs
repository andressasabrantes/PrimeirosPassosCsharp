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
            //Faça um programa que receba dois números e calcule a soma, subtração, multiplicação e divisão.

            int entradaUsuario1, entradaUsuario2;

            Console.Write("Entre um número inteiro positivo: ");
            while (!int.TryParse(Console.ReadLine(), out entradaUsuario1))
            {
                Console.WriteLine("Entrada inválida! Tente novamente...");
                Console.Write("Tente novamente:");
            }

            Console.WriteLine();
            Console.Write("Entre um segundo número inteiro positivo: ");
            while (!int.TryParse(Console.ReadLine(), out entradaUsuario2))
            {
                Console.WriteLine("Entrada inválida!");
                Console.Write("Tente novamente:");
            }

            int soma = entradaUsuario1 + entradaUsuario2;
            int subtracao = entradaUsuario1 - entradaUsuario2;
            int multiplicacao = entradaUsuario1 * entradaUsuario2;
            int divisao = entradaUsuario1 / entradaUsuario2;

            Console.WriteLine();
            Console.WriteLine($" A soma dos números {entradaUsuario1} e do {entradaUsuario2} totaliza em {soma}");
            Console.WriteLine($" A subtração dos números {entradaUsuario1} e do {entradaUsuario2} totaliza em {subtracao}");
            Console.WriteLine($" A multiplicação dos números {entradaUsuario1} e do {entradaUsuario2} totaliza em {multiplicacao}");
            Console.WriteLine($" A divisão dos números {entradaUsuario1} e do {entradaUsuario2} totaliza em {divisao}");


            Console.WriteLine();
            Console.WriteLine("Encerrando programa...");
        }

    }

}
