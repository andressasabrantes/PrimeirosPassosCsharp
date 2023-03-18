using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Você deseja iniciar o programa: S/N");
            char iniciar = char.Parse(Console.ReadLine());
            Console.WriteLine();

            //Validando se o usuário quer começar o programa ou não
            if(iniciar == 's' || iniciar == 'S')
            {
                while (true)
                {

                    int input1, input2, input3;

                    //Primeira validação do primeiro input
                    Console.WriteLine("Insira um número: ");
                    while (!int.TryParse(Console.ReadLine(), out input1))
                    {
                        Console.WriteLine("Entrada inválida! Digite um número válido: ");
                    }


                    //Segunda validação do segundo input
                    Console.WriteLine("Insira o segundo número: ");
                    while (!int.TryParse(Console.ReadLine(), out input2))
                    {
                        Console.WriteLine("Entrada inválida! Digite um número válido: ");
                    }


                    //Terceira validação do terceiro input
                    Console.WriteLine("Insira o terceiro número: ");
                    while (!int.TryParse(Console.ReadLine(), out input3))
                    {
                        Console.WriteLine("Entrada inválida! Digite um número válido: ");
                    }


                    //Chamando o método GetMaxOutOfThree
                    int result = (GetMaxOutOfThree(input1, input2, input3));

                    if (input1 == input2 && input1 == input3)
                    {
                        Console.WriteLine("Todos os números digitados são iguais: " + result);
                    }
                    else
                    {
                        Console.WriteLine("O maior número entre os três digitados é o: " + result);

                    }


                    Console.WriteLine();

                    //Perguntando ao usuário se deseja realizar uma nova comparação
                    Console.WriteLine("Deseja realizar uma nova comparação: S/N");
                    char operation = char.Parse(Console.ReadLine());
                    Console.WriteLine();

                    //Validando se o usuário deseja ou não sair do programa
                    if (operation == 'S' || operation == 's')
                    {
                        continue;
                    }
                    else if (operation == 'N' || operation == 'n')
                    {
                        break;
                    }

                    Console.WriteLine();

                }

            }
            else
            {
                Console.WriteLine("Encerrando Programa...");

            }


        }

        
        static int GetMaxOutOfThree(int num1, int num2, int num3)
        {
            //Metódo para retornar o maior valor entre 3 números 

            int result;
            
            if(num1 > num2 && num1 > num3)
            {
                result = num1;
            } else if (num2 > num1 && num2 > num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }

            return result;
            
        }

    }

}
