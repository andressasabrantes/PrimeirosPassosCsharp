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
            /*1) Implemente um método que crie um novo array baseado nos valores passados.
            Entradas do método(3, a), Resultado do método: ['a', 'a', 'a']*/

            Console.Write("Entre com a quantidade: ");
            int multiplicador = int.Parse(Console.ReadLine());
            Console.Write("Entre com uma letra: ");
            string letra = Console.ReadLine();

            string[] myArray = new string[multiplicador];

            for (int i = 0; i < multiplicador; i++)
            {
                myArray[i] = letra;
            }

            Console.WriteLine("Resultado: [" + string.Join(", ", myArray) + "]");

        }

    }

}
