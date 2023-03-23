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
            //Escreva um programa que leia um número inteiro positivo N e exiba os N primeiros números da sequência de Fibonacci.

            int inputUsuario;

            //Valida a entrada se é um número inteiro
            Console.Write("Insira um número inteiro positivo válido: ");
            while (!int.TryParse(Console.ReadLine(), out inputUsuario))
            {
                Console.WriteLine("Entrada inválida! Tente novamente...");
            }

            //Chama o método Fibonacci
            int[] sequence = Fibonacci(inputUsuario);
            Console.WriteLine("A sequência ");
            Console.WriteLine(string.Join(" ", sequence));

        }

        static int[] Fibonacci(int n)
        {
            int[] sequence = new int[n];//Cria a variável sequence que vai armazenar um array com a sequência

            for (int i = 0; i < n; i++) 
            {
                if (i <= 1)
                {
                    sequence[i] = i;//Se o valor da sequência for 0 ou 1 o valor armazenado no array será o valor da iteração
                }
                else
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2];//Executa a sequência de Fibonacci
                }
            }

            return sequence;
        }

    }

}
