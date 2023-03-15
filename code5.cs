using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o seu nome completo, por favor!");
            string a = Console.ReadLine();

            Console.WriteLine("Digite a sua idade,por favor! ");
            string b = Console.ReadLine();

            Console.WriteLine("Digite a cidade em que você mora, por favor! ");
            string c = Console.ReadLine();

            Console.WriteLine("Bom dia " + a + ","+ " Você tem " + b + " anos " + "e mora na cidade de " + c + "!");
        }
    }
}