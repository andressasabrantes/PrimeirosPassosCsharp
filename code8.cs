using System;
using System.Globalization;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma letra: ");
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número decimal: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine();
            Console.WriteLine("Digite seu nome, sexo, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            
            
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Seu sexo é: " + sexo);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Sua altura é: " + altura);


        }
    }
}
