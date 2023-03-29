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

            //Chama a função ordena, passando como parâmetro a variável 'números'
            Console.WriteLine(string.Join(", ", Ordena(numeros)));

        }

        static List<int> Ordena(List<int> listaNaoOrdenada) 
        {

            //Se a 'listaNaoOrdenada' tiver um tamanho menor ou igual a 1, ela é retornada
            if (listaNaoOrdenada.Count <= 1)
            {
                return listaNaoOrdenada;
            }


            //O primeiro elemento da lista 'listaNaoOrdenada' é escolhido como pivô na comparação
            int target = listaNaoOrdenada[0];

            //Lista criada 'maiores' para armazenar os elementos que são maiores que o pivô
            List<int> maiores = new List<int>();

            //Lista criada 'menores' para armazenar os elementos são menores que o pivô
            List<int> menores = new List<int>();


            //Loop para iterar sobre 'listaNaoOrdenada' e adicionar os elementos em cada lista 'maiores' e 'menores' 
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

            //As listas 'maiores' e 'menores' são ordenadas recursivamente, chamando a própria função Ordena
            maiores = Ordena(maiores);
            menores = Ordena(menores);
            
            //Adicionando o target na lista 'menores', pois ele ainda não tinha sido add em nenhuma das duas listas
            menores.Add(target);

            //Adicionando todos os elementos em apenas uma lista 'menores'
            menores.AddRange(maiores);

            //retorna a lista 'menores'
            return menores;

        }

           
    }

}
