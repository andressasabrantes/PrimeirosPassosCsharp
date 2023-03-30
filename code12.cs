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
            //Faça um programa que receba uma lista de números e retorne uma lista contendo apenas os números pares.

            //Recebe a lista de números do usuário
            Console.Write("Digite números aleatórios: ");
            string entradaUsuario = Console.ReadLine();

            //Transforma a entrada do usário em caracteres e adiciona em um array de strings
            string[] listaDeStrings = entradaUsuario.Split(',', ' ');

            //Transforma o array de strings em uma lista de inteiros
            List<int> entradaUsuarioLista = listaDeStrings.Select(int.Parse).ToList();
                        
            //Chama o método EPar                         
            Console.WriteLine("Os números pares são: " + string.Join(", ", EPar(entradaUsuarioLista)));
            
        }

        static List<int> EPar(List<int> inputUsuario)
        {
            //Inicializa uma lista que vai receber inteiores
            List<int> listaDePares = new List<int>();

            //Itera sobre a lista de inteiros e filtra os que são pares, ou seja, os números que divididos por 2 têm resto 0
            for (int i = 0; i < inputUsuario.Count; i++)
            {

                if (inputUsuario[i] % 2 == 0)
                {
                    listaDePares.Add(inputUsuario[i]);//Adiciona os números pares na lista 'ListaDePares'
                }

            }

            return listaDePares;

        }

    }

}
