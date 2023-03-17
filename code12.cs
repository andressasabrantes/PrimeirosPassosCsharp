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
            
            //Interage com o usuário e Retorna o maior número entre 2 números
            int num1, num2;

            Console.WriteLine("Insira um número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(num1, num2));
            Console.WriteLine();

            //Interage com o usuário e Retorna o maior número entre 3 números
            int number1, number2, number3;

            Console.WriteLine("Insira um número: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um segundo número: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um terceiro número: ");
            number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMaxOutOfThree(number1, number2, number3));
        }

        static int GetMax(int num1, int num2)
        {
            //Retorna o maior número entre 2 números

            int result;

            if (num1 > num2)
            {
                return num1;
            } else
            {
                return num2;
            }
        }

        static int GetMaxOutOfThree(int num1, int num2, int num3)
        {
            //Retorna o maior valor entre 3 números 

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
