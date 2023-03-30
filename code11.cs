using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba uma lista de números e retorne a média, o maior e o menor valor.

            //Recebendo a entrada do usuário e já transformando em um array de inteiros
            Console.Write("Digite vários números aleatórios:");
            string entradaUsuario = Console.ReadLine();
            int[] numbers = entradaUsuario.Split(' ', ',').Select(int.Parse).ToArray();

            //Passando o for pelo array 'Numbers' e fazendo a soma dos inteiros
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            //Pego o resultado de 'Result' e divido pelo tamanho do array 'Numbers' para conseguir a média dos valores
            int avg = result / numbers.Length;
            
            //Ordenando o array 'Numbers' para conseguir pegar o menor e o maior valor do array
            Array.Sort(numbers);
            
            //Acessando o menor valor do Array 'Numbers'
            int menorValor = numbers[0];

            //Atribuindo o último índice do array 'Numbers' em 'ultimoIndice' e na linha seguinte acessando o valor do 'UltimoIndice'
            int ultimoIndice = numbers.Length - 1;
            int maiorValor = numbers[ultimoIndice];


            Console.WriteLine("A média é {0}, o maior valor é {1} e o menor valor é {2}", avg, maiorValor, menorValor);

        }

    }

}
