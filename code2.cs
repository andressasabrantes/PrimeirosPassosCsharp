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

            //Escreva um programa que leia um número inteiro e exiba se esse número é par ou ímpar.

            int firstOne;

            Console.Write("Entre um número inteiro válido: ");
            while(!int.TryParse(Console.ReadLine(), out firstOne))
            {
                Console.Write("Entrada inválida! Entre um número inteiro: ");
            }

            if (firstOne % 2 == 0)
            {
                Console.Write(firstOne + " É PAR!");
            } else
            {
                Console.Write("É IMPAR!");
            }

        }

    }

}
