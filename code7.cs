using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira letra do seu nome: ");
            char letra = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());


            Console.WriteLine("Seu nome é " + nome + " e sua idade é " + idade + " anos");
            Console.WriteLine();
            Console.WriteLine("Agora insira os 3 itens mais importante da sua lista de compras: ");

            string[] listaDeCompras = Console.ReadLine().Split(',');
            string a = listaDeCompras[0];
            string b = listaDeCompras[1];
            string c = listaDeCompras[2];

            Console.WriteLine("Seus 3 itens mais importantes são: " + a + "" + b + " e" + c);


        }
    }
}