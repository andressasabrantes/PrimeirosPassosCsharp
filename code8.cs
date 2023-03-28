using System;
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
            //Faça um programa que receba uma frase e verifique se ela é um palíndromo (ou seja, se pode ser lida da mesma forma de trás para frente).

            Console.Write("Escreva uma frase para o programa verificar se é um palíndromo: ");
            string entradaUsuarioFrase = Console.ReadLine();

            //Cria uma matriz de caracteres para dividir a entrada do usuário
            char[] divideFrase = {' ', '.', ';', ',', ':', '!', '?'};

            //Cria uma nova lista de strings dividida em pedaços a partir de divideFrase
            List<string> fraseSemEspacos = entradaUsuarioFrase.Split(divideFrase, StringSplitOptions.RemoveEmptyEntries).ToList();

            //Chama a função EPalindromo passando a lista fraseSemEspacos, que está dividida, como parametro
            Console.WriteLine(EPalindromo(fraseSemEspacos));

        }

        static bool EPalindromo(List<string> frase)
        {

            //Cria uma lista vazia para receber os caracteres do parâmetro 'frase'
            List<char> fraseEmCaracteres = new List<char>();

            //Itera sobre 'frase' que foi recebida no parâmetro, converte em caracteres e adiciona na lista 'fraseEmCaracteres', que antes estava vazia
            foreach (string word in frase)
            {
                fraseEmCaracteres.AddRange(word.ToCharArray());
            }

            //Cria uma lista vazia para receber os caracteres invertidos da lista 'fraseEmCaracteres'
            List<char> fraseAoContrario = new List<char>();
            
            //Itera sobre 'fraseEmCaracteres' invertendo a ordem dos caracteres e adiciona-os na lista 'fraseAoContrário', criada anteriormente
            for (int i = fraseEmCaracteres.Count - 1; i >= 0; i--)
            {
                fraseAoContrario.Add(fraseEmCaracteres[i]);
            }

            //Chama a função VerificaLista e verifica se o parâmetro2 é o parâmetro1 invertido, ou seja, palíndromo
            return VerificaLista(fraseEmCaracteres, fraseAoContrario);

        }

        //Função genérica para iterar sobre cada caracter e comparar duas listas de caracteres
        static bool VerificaLista(List<char> primeiraLista, List<char> segundaLista)
        {
            //Caso as listas passadas no parâmetro tenham tamanhos diferentes, já tem retorno falso
            if (primeiraLista.Count != segundaLista.Count)
            {
                return false;
            }

            //Itera por cada caractere, compara as duas listas, passadas por parâmetro, se os caracteres são os mesmos. Se nenhum caractere for diferente o for não entra na condição if e retorna true 
            for (int i = 0; i < primeiraLista.Count; i++)
            {
                if (primeiraLista[i] != segundaLista[i])
                {
                    return false;
                }
            }

            return true;
        } 
            
    }

}
