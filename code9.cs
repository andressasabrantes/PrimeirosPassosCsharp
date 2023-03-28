using System;
using System.Collections;
using System.Collections.Generic;
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
            //Faça um programa que receba uma lista de números e ordene - os em ordem crescente.

            List<int> numeros = new List<int>();

            Console.Write("Insira uma lista de números aleatórios separados por vírgula ou espaço: ");
            string entrada = Console.ReadLine();

            // Dividir a entrada do usuário em uma matriz de strings usando Split com espaço e vírgula como separadores
            string[] numerosComoString = entrada.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Converter cada elemento da matriz em um número inteiro usando Parse
            foreach (string numeroComoString in numerosComoString)
            {
                int numero;
                if (Int32.TryParse(numeroComoString, out numero))
                {
                    // Adicionar cada número inteiro à lista
                    numeros.Add(numero);
                }
            }

            Console.WriteLine(string.Join(", ", Ordena(numeros)));

        }

        static List<int> Ordena(List<int> listaNaoOrdenada) 
        {

            if (listaNaoOrdenada.Count <= 1)
            {
                return listaNaoOrdenada;
            }


            int target = listaNaoOrdenada[0];
            List<int> maiores = new List<int>();
            List<int> menores = new List<int>();


            for (int i = 1; i < listaNaoOrdenada.Count; i++)
            {
                if (listaNaoOrdenada[i] < target)
                {
                    menores.Add(listaNaoOrdenada[i]);
                }
                else
                {
                    maiores.Add(listaNaoOrdenada[i]);
                }

            }

            maiores = Ordena(maiores);
            menores = Ordena(menores);

            menores.Add(target);
            menores.AddRange(maiores);

            return menores;

        }

           
    }

}
