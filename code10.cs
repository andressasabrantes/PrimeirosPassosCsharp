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
            //Faça um programa que receba duas strings e verifique se elas são anagramas (ou seja, se possuem as mesmas letras, mas em ordem diferente).


            //recebendo a primeira palavra do usuário
            Console.Write("Digite uma palavra: ");
            string entrada1 = Console.ReadLine();

            //recebendo a segunda palavra do usuário
            Console.WriteLine();
            Console.Write("Digite uma segunda palavra para testarmos se é um anagrama da primeira: ");
            string entrada2 = Console.ReadLine();

            if (entrada1.Length != entrada2.Length)
            {
                Console.WriteLine("As palavras não são anagramas");
            }
            else
            {
                //Transformando a entrada do usuário em uma lista de caractere armazenada em lista1 e lista2, respectivamente
                List<char> charLista1 = new List<char>(entrada1.ToList());
                List<char> charLista2 = new List<char>(entrada2.ToList());

                //Ordenando as listas
                charLista1.Sort();
                charLista2.Sort();

                //transformando as listas de caracteres em strings ordenadas para verificar depois
                string stringOrdenada = new string(charLista1.ToArray());
                string stringOrdeanda2 = new string(charLista2.ToArray());

                //comparando se os arrays têm os mesmos caracteres
                if (stringOrdenada == stringOrdeanda2)
                {
                    Console.WriteLine("As palavras são anagramas!");
                }
                else
                {
                    Console.WriteLine("As palavras não são anagramas!");
                }

            }

        }

    }

}
