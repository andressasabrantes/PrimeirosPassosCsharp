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
            //Faça um programa que receba uma lista de nomes e retorne uma lista contendo apenas os nomes que começam com a letra "A".

            Console.Write("Digite nomes de pessoas: ");
            string entradaUsuario = Console.ReadLine();

            string[] subStrings = entradaUsuario.Split(' ', ',');

            List<string> entradaUsuarioLista = subStrings.ToList();

            Console.WriteLine("Os nomes que começam com a letra A são: " + string.Join(", ", ListaDeA(entradaUsuarioLista)));
       
        }

        static List<string> ListaDeA(List<string> listaDeNomes)
        {

            List<string> nomesComA = new List<string>();

            for (int i = 0; i < listaDeNomes.Count; i++)
            {
                if (listaDeNomes[i][0] == 'A' || listaDeNomes[i][0] == 'a')
                {
                    nomesComA.Add(listaDeNomes[i]);
                }
            }

            return nomesComA;

        }

    }

}
