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
            //Faça um programa que receba um número e verifique se ele é primo ou não.
                                  
                int entradaUsuario;
                
                Console.Write("Digite um número: ");
                while (!int.TryParse(Console.ReadLine(), out entradaUsuario))
                {
                    Console.Write("Entrada inválida!Tente novamente: ");
                }

                Console.Write(IsPrime(entradaUsuario));
                Console.WriteLine();       
                
        }

        public static string IsPrime(int number)
        {
            if (number <= 1) return "Não é primo!"; // 1 e números negativos não são primos

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return "Não é primo!"; // se o número é divisível por i, então não é primo
                }
            }

            return "É primo!"; // se o número passou por todos os testes, então é primo
        }

    }

}
