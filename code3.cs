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


            while (true)
            {

                int tabuadaDe;

                //validação da entrada de um número inteiro
                Console.WriteLine();
                Console.WriteLine("Entre o número que você deseja ver a tabuada: ");
                while (!int.TryParse(Console.ReadLine(), out tabuadaDe))
                {
                    Console.Write("Entrada inválida! Digite um número válido: ");
                }

                //chamando o método Tabuada
                Console.Write(Tabuada(tabuadaDe));

                              
                //perguntando ao usuário se deseja fazer uma nova operação e validando se a entrada do usuário tem um caractere de comprimento e se é 's' ou 'S' para continuar ou 'n' ou 'N' para sair
                char operation;

                while (true)
                {

                    Console.WriteLine();
                    Console.Write("Digite S para continuar ou N para sair: ");
                    string inputUsuario = Console.ReadLine();

                    //validando o tamanho da string do input do usuário e se são as entradas pedidas
                    if (inputUsuario.Length == 1 && (inputUsuario[0] == 'S' || inputUsuario[0] == 's'))
                    {
                        operation = 'S';
                        break;
                    }
                    else if (inputUsuario.Length == 1 && (inputUsuario[0] == 'N' || inputUsuario[0] == 'n'))
                    {
                        operation = 'N';
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Resposta Inválida!");
                    }

                }

                if (operation == 'S')
                {
                    continue;
                }
                else
                {
                    Console.Write("Encerrando programa...");
                    break;
                }


            }
            

        }

        static string Tabuada(int multiplo)
        {

            //método para fazer as multplicações
                      
            Console.WriteLine("1 x " + multiplo + " = " + (1 * multiplo)); 
            Console.WriteLine("2 x " + multiplo + " = " + (2 * multiplo)); 
            Console.WriteLine("3 x " + multiplo + " = " + (3 * multiplo)); 
            Console.WriteLine("4 x " + multiplo + " = " + (4 * multiplo)); 
            Console.WriteLine("5 x " + multiplo + " = " + (5 * multiplo)); 
            Console.WriteLine("6 x " + multiplo + " = " + (6 * multiplo)); 
            Console.WriteLine("7 x " + multiplo + " = " + (7 * multiplo)); 
            Console.WriteLine("8 x " + multiplo + " = " + (8 * multiplo)); 
            Console.WriteLine("9 x " + multiplo + " = " + (9 * multiplo));
            Console.WriteLine("10 x " + multiplo + " = " + (10 * multiplo));

            Console.WriteLine();
            return "A tabuada de " + multiplo + " foi exibida com sucesso!";
            
        }
    }

}
