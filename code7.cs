using System;
using System.Collections.Generic;
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
                //usuário escolhe a operação
                Console.Write("Escolha a operação que deseja fazer: + ou - ou * ou / ? ");
                string operation = Console.ReadLine();


                //condição da operação
                if (operation == "+")
                {

                    Console.Write("Enter a number: ");
                    double sum1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter a second number: ");
                    double sum2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(sum1 + sum2);

                }
                else if (operation == "-")
                {

                    Console.Write("Enter a number: ");
                    double sub1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter a second number: ");
                    double sub2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(sub1 - sub2);

                }
                else if (operation == "*")
                {

                    Console.Write("Enter a number: ");
                    double multiplication1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter a second number: ");
                    double multiplication2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(multiplication1 * multiplication2);

                }
                else if (operation == "/")
                {

                    Console.Write("Enter a number: ");
                    double division1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter a second number: ");
                    double division2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(division1 / division2);

                }

                Console.WriteLine("Você gostaria de fazer outra operação? S/N");
                char sair = Convert.ToChar(((Console.ReadLine())));

                if (sair == 'S' || sair == 's')
                {
                    continue;
                }
                else if (sair == 'N' || sair == 'n')
                {
                    break;
                }

            }

        }

    }

}
