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
            //Escreva um programa que leia dois números inteiros e exiba o resultado da soma desses números.

            int firstNumber, secondNumber;

            Console.Write("Entre um número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Entrada inválida. Entre um número inteiro!");
            }

            Console.Write("Entre um outro número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Entrada inválida. Entre um número inteiro!");
            }

            Console.WriteLine(firstNumber + secondNumber);
        }

    }

}
