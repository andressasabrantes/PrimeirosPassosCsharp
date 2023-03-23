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

            long entradaDoUsuario;

            //Valida se a entrada é um número inteiro positivo
            Console.WriteLine();
            Console.Write("Insira um número para exibir a sequência de Fibonacci: ");
            while (!long.TryParse(Console.ReadLine(), out entradaDoUsuario) || (entradaDoUsuario < 0))
            {
                Console.WriteLine("Oops, entrada inválida!");
                Console.Write("Insira um número inteiro positivo válido: ");
            }

            //Chama o método Fibonacci
            long[] sequencia = Fibonacci(entradaDoUsuario);
            Console.Write("A sequência fica assim: ");
            Console.Write(string.Join(" ", sequencia));
            Console.WriteLine();
        }

        static long[] Fibonacci(long parametroDeParada)
        {
            long[] sequencia = new long[parametroDeParada];//Cria a variável sequence que vai armazenar um array com a sequência

            for (int i = 0; i < parametroDeParada; i++) 
            {
                if (i <= 1)
                {
                    sequencia[i] = i;//Se o valor da sequência for 0 ou 1 o valor armazenado no array será o valor da iteração
                }
                else
                {
                    sequencia[i] = sequencia[i - 1] + sequencia[i - 2];//Executa a sequência de Fibonacci. Cada número seguinte é a soma dos dois números anteriores n = (n-1) + (n-2)
                }
            }

            return sequencia;
        }

    }

}
