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
            //Faça um programa que receba um número e retorne uma lista contendo todos os números primos menores ou iguais a ele.

            Console.Write("Digite um número e descubra quais são os números primos até ele: ");
            int entradaUsuário = int.Parse(Console.ReadLine());

            Console.WriteLine("Os números primos são: " + string.Join(", ", ListaDePrimos(entradaUsuário)));

        }

        static List<int> ListaDePrimos(int numeroDoUsuario)
        {
            List<int> primos = new List<int>();

            for (int i = 2; i <= numeroDoUsuario; i++)
            {
                if (IsPrime(i) == i)
                {
                    primos.Add(i);
                }
            }

            return primos;
        }

        static int IsPrime(int number)
        {
            if (number < 2)
            {
                return 0;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }

            return number;
        }

    }

}
