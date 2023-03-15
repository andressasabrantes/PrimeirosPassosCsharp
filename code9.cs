using System;
using System.Globalization;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Digite o seu sobrenome, idade e altura (na mesma linha): ");
            string[] dadosUsuario = Console.ReadLine().Split(' ');

            string sobrenome = dadosUsuario[0];
            int idade = int.Parse(dadosUsuario[1]);
            double altura = double.Parse(dadosUsuario[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Confira os seus dados informados: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(dadosUsuario[0]);
            Console.WriteLine(dadosUsuario[1]);
            Console.WriteLine(dadosUsuario[2]);
        }
    }
}
