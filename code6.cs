using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome completo: ");
            
            string[] nomeCompleto = Console.ReadLine().Split(' ');
            string nome = nomeCompleto[0];
            string nomeDoMeio = nomeCompleto[1];
            string sobrenome = nomeCompleto[2];

            Console.WriteLine("Seu nome é " + nome + ", seu nome do Meio é " + nomeDoMeio + " e o seu sobrenome é " + sobrenome + ".");

        }
    }
}